using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Net.NetworkInformation;

namespace UDPChat
{
    public partial class UDP
    {
        private static IPAddress remoteIPAddress;
        private static Dictionary<string, IPAddress> LANAddresses;
        private static int remotePort;
        private static int localPort;
        private Thread receiver;
        private string password;
        public delegate void MessageReceived(string _message);
        public event MessageReceived Notify;

        public UDP(string _portSend, string _portReceive, string _password, string _ip)
        {
            FindAllComputersInLAN();
            remotePort = Convert.ToInt32(_portSend);
            localPort = Convert.ToInt32(_portReceive);
            password = _password;
            remoteIPAddress = IPAddress.Parse(_ip);

            receiver = new Thread(new ThreadStart(Receive));
            receiver.Start();
        }

        private void FindAllComputersInLAN()
        {
            if (NetworkInterface.GetIsNetworkAvailable())
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        Console.WriteLine(ip.ToString());
                    }
                }
            }
            return;
            string who = "127.0.0.1";
            AutoResetEvent waiter = new AutoResetEvent(false);

            Ping pingSender = new Ping();
            pingSender.PingCompleted += new PingCompletedEventHandler(PingCompletedCallback);

            string data = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            int timeout = 12000;
            PingOptions options = new PingOptions(64, true);

            Console.WriteLine("Time to live: {0}", options.Ttl);
            Console.WriteLine("Don't fragment: {0}", options.DontFragment);

            pingSender.SendAsync(who, timeout, buffer, options, waiter);

            Console.WriteLine("Ping example completed.");
        }

        private static void PingCompletedCallback(object sender, PingCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                Console.WriteLine("Ping canceled.");
               ((AutoResetEvent)e.UserState).Set();
            }

            if (e.Error != null)
            {
                Console.WriteLine("Ping failed:");
                Console.WriteLine(e.Error.ToString());
                ((AutoResetEvent)e.UserState).Set();
            }
            PingReply reply = e.Reply;
            DisplayReply(reply);
            ((AutoResetEvent)e.UserState).Set();
        }

        public static void DisplayReply(PingReply reply)
        {
            if (reply == null)
                return;

            Console.WriteLine("ping status: {0}", reply.Status);
            if (reply.Status == IPStatus.Success)
            {
                Console.WriteLine("Address: {0}", reply.Address.ToString());
                Console.WriteLine("RoundTrip time: {0}", reply.RoundtripTime);
                Console.WriteLine("Time to live: {0}", reply.Options.Ttl);
                Console.WriteLine("Don't fragment: {0}", reply.Options.DontFragment);
                Console.WriteLine("Buffer size: {0}", reply.Buffer.Length);
            }
        }

        public void CloseAllConnections()
        {
            receiver.Interrupt();
        }

        public void Send(string _datagram)
        {
            UdpClient sender = new UdpClient();
            IPEndPoint endPoint = new IPEndPoint(remoteIPAddress, remotePort);

            try
            {
                byte[] bytesToSend = Encrypt(Encoding.UTF8.GetBytes(_datagram));
                sender.Send(bytesToSend, bytesToSend.Length, endPoint);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
            }
            finally
            {
                sender.Close();
            }
        }

        public byte[] Encrypt(byte[] _plainText)
        {
            SHA256CryptoServiceProvider hashFunction = new SHA256CryptoServiceProvider();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            int roundsCount = _plainText.Length / 32 + 1;
            byte[] cypherText = new byte[_plainText.Length];
            byte[] roundPasswordBytes = new byte[passwordBytes.Length + 1];
            System.Buffer.BlockCopy(passwordBytes, 0, roundPasswordBytes, 0, passwordBytes.Length);
            for (int i = 0; i < roundsCount; i++)
            {
                roundPasswordBytes[roundPasswordBytes.Length - 1] = (byte)i;
                byte[] gamma = hashFunction.ComputeHash(roundPasswordBytes);
                for (int j = 0; j < 32 && i * 32 + j < _plainText.Length; j++)
                {
                    cypherText[i * 32 + j] = (byte)(_plainText[i * 32 + j] ^ gamma[j]);
                }
            }
            return cypherText;
        }

        public byte[] Decrypt(byte[] _cypherText)
        {
            SHA256CryptoServiceProvider hashFunction = new SHA256CryptoServiceProvider();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            int roundsCount = _cypherText.Length / 32 + 1;
            byte[] plainText = new byte[_cypherText.Length];
            byte[] roundPasswordBytes = new byte[passwordBytes.Length + 1];
            System.Buffer.BlockCopy(passwordBytes, 0, roundPasswordBytes, 0, passwordBytes.Length);
            for (int i = 0; i < roundsCount; i++)
            {
                roundPasswordBytes[roundPasswordBytes.Length - 1] = (byte)i;
                byte[] gamma = hashFunction.ComputeHash(roundPasswordBytes);
                for (int j = 0; j < 32 && i * 32 + j < _cypherText.Length; j++)
                {
                    plainText[i * 32 + j] = (byte)(_cypherText[i * 32 + j] ^ gamma[j]);
                }
            }
            return plainText;
        }


        public async void Receive()
        {
            UdpClient receivingUdpClient = new UdpClient(localPort);  
            try
            {
                while(true)
                { 
                    var udpReceiveResult = await receivingUdpClient.ReceiveAsync();
                    byte[] receiveBytes = udpReceiveResult.Buffer;
                    string returnData = Encoding.UTF8.GetString(Decrypt(receiveBytes));
                    Notify?.Invoke(returnData);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
            }
        }


    }
}
