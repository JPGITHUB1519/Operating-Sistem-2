using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AsyncClientForm
{
    class utitilities
    {
        private static string user_dir = @"../../../../database/user.txt"; 
        public static void writeSingleLineToFile(string dir, string line)
        {
            using (System.IO.StreamWriter file = File.AppendText(dir))
            {
                file.WriteLine(line);
            }
        }
    }
}
