using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
namespace AsyncClientForm
{
    class CommunicationClient
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

        public static void Connect()
        {
            int attempts = 0;
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch (SocketException ex)
                {
                    MessageBox.Show("Connectiom Attemps : " + attempts);
                }
            }
            MessageBox.Show("Connected");
        }

        public static string sendRequestForString(string request)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(request);
            _clientSocket.Send(buffer);
            // receive data from server
            byte[] receivedBuf = new byte[1024];
            int rec = _clientSocket.Receive(receivedBuf);
            byte[] data = new byte[rec];
            Array.Copy(receivedBuf, data, rec);
            return Encoding.ASCII.GetString(data);
        }
    }
}
