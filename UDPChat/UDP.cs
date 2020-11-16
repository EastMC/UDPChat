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

namespace UDPChat
{
    class UDP
    {
        private static IPAddress remoteIPAddress = IPAddress.Parse("127.0.0.1");
        private static int remotePort;
        private static int localPort;
        private Thread receiver;
        private static bool isListening = true;

        public delegate void MessageReceived(string _message);
        public event MessageReceived Notify;

        public UDP(string _portSend, string _portReceive)
        {
            remotePort = Convert.ToInt32(_portSend);
            localPort = Convert.ToInt32(_portReceive);

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
                byte[] bytesToSend = Encoding.UTF8.GetBytes(_datagram);
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

                    string returnData = Encoding.UTF8.GetString(receiveBytes);
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
