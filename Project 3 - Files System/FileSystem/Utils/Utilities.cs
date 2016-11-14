using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace Utils
{
    public class Utilities
    {
        public static char sep = ',';
        public static string provincia_dir = "file.txt";

        public static List<string> readFileByList(string dir)
        {
            int counter = 0;
            string line;
            List<string> lista = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(dir);
            while ((line = file.ReadLine()) != null)
            {
                lista.Add(line);
                counter++;
            }
            file.Close();

            return lista;
        }

        public static void writeListToFile(string dir, List<string> lista)
        {
            using (System.IO.StreamWriter file = File.AppendText(dir))
            {
                foreach (string line in lista)
                {
                    file.WriteLine(line);
                }
            }
        }

        public static void writeSingleLineToFile(string dir, string line)
        {
            using (System.IO.StreamWriter file = File.AppendText(dir))
            {
               file.WriteLine(line);
            }
        }

        public static void deleteFromFileById(string dir, int id)
        {
            // vaciar archivo
            //System.IO.File.WriteAllText(dir, string.Empty);
            string line;
            System.IO.StreamReader file = new System.IO.StreamReader(dir);
            // eliminar dato
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                if (Convert.ToInt32(words[0]) != id)
                {
                    Console.Write(words[0]);
                    Utilities.writeSingleLineToFile(dir, line);
                }
            }
            file.Close();
        }

        // fill datatable from a file
        public static DataTable fileToDataTable(string dir)
        {
            System.IO.StreamReader file = new System.IO.StreamReader(dir);
            string[] columnnames = file.ReadLine().Split(Utilities.sep);
            DataTable dt = new DataTable();
            foreach (string c in columnnames)
            {
                dt.Columns.Add(c);
            }
            string newline;
            while ((newline = file.ReadLine()) != null)
            {
                DataRow dr = dt.NewRow();
                string[] values = newline.Split(Utilities.sep);
                for (int i = 0; i < values.Length - 1; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
            file.Close();
            return dt;
        }
        
    }
}
