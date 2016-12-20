using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
namespace AsyncServer
{
    class Program
    {
        private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static List<Socket> _clientSockets = new List<Socket>();
        private static byte[] _buffer = new Byte[1024];
        static IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("148.255.64.94"), 100);
        
        static void Main(string[] args)
        {
            Console.Title = "Server";
            setupServer();
            Console.ReadKey();
        }

        private static void setupServer()
        {
            Console.WriteLine("Setting Up Server...");
            _serverSocket.Bind(direccion);
            _serverSocket.Listen(1);
            // aceptar conexion
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
        }

        private static void AcceptCallBack(IAsyncResult AR)
        {
            // aceptar conexion y añadirla a la lista de conexiones
            Socket socket = _serverSocket.EndAccept(AR);
            _clientSockets.Add(socket);
            Console.WriteLine("Client Connected");
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);

            // aceptar nueva conexion
            _serverSocket.BeginAccept(new AsyncCallback(AcceptCallBack), null);
        }

        private static void ReceiveCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            int received = socket.EndReceive(AR);
            byte[] databuf = new byte[received];
            Array.Copy(_buffer, databuf, received);
            // receiving text from client
            string text = Encoding.ASCII.GetString(databuf);
            Console.WriteLine("Text Received : " + text);
            // enviar data a cliente
            string response = string.Empty;
            if (text.ToLower() != "get time")
            {
                response = "Invalid Request";
            }
            else
            {
                response = DateTime.Now.ToLongTimeString();
            }

            byte[] data = Encoding.ASCII.GetBytes(response);
            socket.BeginSend(data, 0, data.Length, SocketFlags.None, new AsyncCallback(SendCallBack), socket);
            // receive again after send
            socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
        }

        private static void SendCallBack(IAsyncResult AR)
        {
            Socket socket = (Socket)AR.AsyncState;
            socket.EndSend(AR);
        }
    }
}
