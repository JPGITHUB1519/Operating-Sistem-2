using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ClientConsole
{
    public class ComunicationClient
    {
        public static Socket mysocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        // ip
        public static IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("10.0.0.10"), 1234);
   
        public static void conectar()
        {
            try
            {
                // conectando
                mysocket.Connect(direccion);
                Console.WriteLine("Conectado Con Exito");
                /* codigo a ejecutar */
                sendString(mysocket, "HOLA amigo");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex.ToString());
            }
            Console.WriteLine("Presione cualquier Tecla para terminar...");
            Console.ReadKey();
        }

        public static void conectarConsola()
        {
            try
            {
                // conectando
                mysocket.Connect(direccion);
                Console.WriteLine("Conectado Con Exito");
                /* codigo a ejecutar */
                sendString(mysocket, "HOLA amigo");
                desconectar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex.ToString());
            }
            Console.WriteLine("Presione cualquier Tecla para terminar...");
            Console.ReadKey();
        }

        public static void desconectar()
        {
             mysocket.Close();
        }

        public static void sendString(Socket socket, string string_to_send)
        {
            byte[] data = System.Text.Encoding.ASCII.GetBytes(string_to_send);
            socket.Send(data);
        }


   }
}
