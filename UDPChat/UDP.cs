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

namespace UDPChat
{
    class UDP
    {
        private static IPAddress remoteIPAddress;
        private static int remotePort;
        private static int localPort;
        private Thread receiver;
        private static bool isListening = true;
        private string password;

        public delegate void MessageReceived(string _message);
        public event MessageReceived Notify;

        public UDP(string _portSend, string _portReceive, string _password, string _ip)
        {
            remotePort = Convert.ToInt32(_portSend);
            localPort = Convert.ToInt32(_portReceive);
            password = _password;
            remoteIPAddress = IPAddress.Parse(_ip);

            receiver = new Thread(new ThreadStart(Receive));
            receiver.Start();
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


        public void Receive()
        {
            UdpClient receivingUdpClient = new UdpClient(localPort);
            
            IPEndPoint RemoteIpEndPoint = null;
            try
            {
                while (isListening)
                {
                    byte[] receiveBytes = receivingUdpClient.Receive(
                       ref RemoteIpEndPoint);

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
