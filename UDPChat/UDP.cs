using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UDPChat
{   
    class UDP
    {
        private static IPAddress remoteIPAddress;
        private static int remotePort;
        private static int localPort;

        private static void Send(string _datagram)
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

        public static void Receive()
        {
            UdpClient receivingUdpClient = new UdpClient(localPort);
            IPEndPoint RemoteIpEndPoint = null;
            try
            {
                while (true)
                {
                    byte[] receiveBytes = receivingUdpClient.Receive(
                       ref RemoteIpEndPoint);

                    string returnData = Encoding.UTF8.GetString(receiveBytes);
                    Console.WriteLine(" --> " + returnData.ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Возникло исключение: " + ex.ToString() + "\n  " + ex.Message);
            }
        }


    }
}
