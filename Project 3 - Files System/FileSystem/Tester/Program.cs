using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //string texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam ut sapien tortor.";
            string texto = "jean";
            string encrypted = Encrypt.encriptar(texto);
            Console.WriteLine(encrypted);
            encrypted = Encrypt.desencriptar(encrypted);
            Console.WriteLine("\n\n" + encrypted);
            Console.ReadKey();

        }
    }
}
