using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ServerConsole
{
    public class ComunicationServer
    {
        public static Socket mysocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        // ip
        public static IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("10.0.0.10"), 1234);

        public static string conectar()
        {
            string status = "Conectado Exitosamente, Recibiendo Peticion...";
            try
            {
                // ## creando servidor
                // asociando ip a socket
                mysocket.Bind(direccion);
                // escuchar y ponemos cantidad
                mysocket.Listen(1);
                Console.WriteLine("Escuchando....");
                // creando nuevo socket para comenzar a trabajar con el
                Socket escuchar = mysocket.Accept();
                // queda en reposo hasta que se conecte cliente
                //Console.WriteLine("Conectado con Exito");
                /* aqui va todo lo que queremos hacer al conectar */
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error : {0}", ex.ToString());
                status = "Error : " + ex.ToString();
            }
            return status;
            //Console.WriteLine("Presione cualquier tecla para terminar...");
            //Console.ReadKey();
        }

        public static void conectarConsola()
        {
            try
            {
                // ## creando servidor
                // asociando ip a socket
                mysocket.Bind(direccion);
                // escuchar y ponemos cantidad
                mysocket.Listen(1);
                Console.WriteLine("Escuchando....");
                // creando nuevo socket para comenzar a trabajar con el
                Socket escuchar = mysocket.Accept();
                // queda en reposo hasta que se conecte cliente
                Console.WriteLine("Conectado con Exito");
                string received = receiveString(escuchar);
                Console.WriteLine(received);
                /* aqui va todo lo que queremos hacer al conectar */
                desconectar();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : {0}", ex.ToString());
            }
            Console.WriteLine("Presione cualquier tecla para terminar...");
            Console.ReadKey();
        }

        public static void desconectar()
        {
            mysocket.Close();
        }

        // recibir string
        public static string receiveString(Socket escuchar)
        {
            byte[] buffer = new byte[1024];
            int k = escuchar.Receive(buffer);
            string received = Encoding.ASCII.GetString(buffer, 0, k);
            return received;
        }
    }
}
