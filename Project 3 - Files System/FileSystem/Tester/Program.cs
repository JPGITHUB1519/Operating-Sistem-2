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
            Utilities.deleteFromFileById(Utilities.provincia_dir, 1);
            Console.ReadKey();
        }
    }
}
