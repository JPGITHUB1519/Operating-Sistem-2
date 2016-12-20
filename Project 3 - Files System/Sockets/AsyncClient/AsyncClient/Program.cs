using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace AsyncClient
{
    class Program
    {
        private static Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        static void Main(string[] args)
        {
            Console.Title = "Client";
            loopConnect();
            sendLoop();
            Console.ReadKey();
        }

        private static void loopConnect()
        {
            int attempts = 0; 
            while (!_clientSocket.Connected)
            {
                try
                {
                    attempts++;
                    _clientSocket.Connect(IPAddress.Loopback, 100);
                }
                catch(SocketException ex)
                {
                    Console.Clear();
                    Console.WriteLine("Connectiom Attemps : " + attempts);
                }  
            }

            Console.Clear();
            Console.WriteLine("Connected");
        }

        // TO SEND REQUEST IN A infinite loop
        public static void sendLoop()
        {
            while (true)
            {
                // test server with multiple request
                // testing
                //Thread.Sleep(500);
                // send data to server
                Console.WriteLine("Enter a Request : ");
                string req = Console.ReadLine();
                //byte[] buffer = Encoding.ASCII.GetBytes(req);
                // testing
                byte[] buffer = Encoding.ASCII.GetBytes(req);
                _clientSocket.Send(buffer);
                // receive data from server
                byte[] receivedBuf = new byte[1024];
                int rec = _clientSocket.Receive(receivedBuf);
                byte[] data = new byte[rec];
                Array.Copy(receivedBuf, data, rec);
                string response_to_string = Encoding.ASCII.GetString(data);
                // printing string
                //Console.WriteLine("Received : " + response_to_string);

                //printing string []
                string[] records = queryResultStripper(response_to_string);
                foreach(string record in records)
                {
                    Console.WriteLine(record);
                }

            }
            
        }

        // strip results from server
        public static string[] queryResultStripper(string result)
        {
            string[] records = result.Split('[');
            return records;
        }
    }
}
