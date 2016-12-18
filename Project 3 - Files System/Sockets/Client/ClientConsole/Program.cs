using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace ClientConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("##### Cliente ##### \n\n");
            ComunicationClient.conectar();
            Console.ReadKey();
        }
    }
}
