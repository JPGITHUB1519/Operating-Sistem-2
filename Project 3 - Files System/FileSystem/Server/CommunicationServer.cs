using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Utils
{
    public class CommunicationServer
    {
        private static Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private static List<Socket> _clientSockets = new List<Socket>();
        private static byte[] _buffer = new Byte[1024];
        static IPEndPoint direccion = new IPEndPoint(IPAddress.Any, 100);

        public static void setupServer()
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
            string request = Encoding.ASCII.GetString(databuf);
            List<string> lista = new List<string>();
            Console.WriteLine("Text Received : " + request);
            // enviar data a cliente
            string response = string.Empty;
            if (request.ToLower() != "")
            {
                //response = DateTime.Now.ToLongTimeString();
                // make request and return
                response = Utilities.executeQueryReturnString(request);
            }
            else
            {
                response = "Invalid Request";
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

        public static string executeQueryReturnString(string query)
        {
            query = query.ToLower();
            Dictionary<string, object> filters = new Dictionary<string, object>();
            filters = Utilities.selectQueryReader(query);
            string table_name = (string)filters["table_name"];
            List<string> result = new List<string>();
            string result_string = "";

            if (table_name == "municipio")
            {
                result = Municipio.filterMunicipio(filters);
            }

            if (table_name == "provincia")
            {
                result = Provincia.filterProvincia(filters);
            }

            if (table_name == "barrio")
            {
                result = result = Barrio.filterBarrio(filters);
            }

            if (table_name == "urbanizacion")
            {
                result = result = Urbanizacion.filterUrbanizacion(filters);
            }

            if (table_name == "distrito_municipal")
            {
                result = result = DistritoMunicipal.filterDistritoMunicipal(filters);
            }

            if (table_name == "seccion_dm")
            {
                result = result = SeccionDM.filterSeccionDM(filters);
            }

            if (table_name == "barrio_dm")
            {
                result = result = BarrioDM.filterBarrioDM(filters);
            }

            if (table_name == "urbanizacion_dm")
            {
                result = result = UrbanizacionDM.filterUrbanizacionDM(filters);
            }

            if (table_name == "persona")
            {
                result = result = Persona.filterPersona(filters);
            }

            for (int i = 0; i < result.Count; i++)
            {
                if (i != result.Count - 1)
                {
                    result_string += result[i] + "[";
                }
                else
                {
                    result_string += result[i];
                }

            }

            return result_string;
        }
    }
}
