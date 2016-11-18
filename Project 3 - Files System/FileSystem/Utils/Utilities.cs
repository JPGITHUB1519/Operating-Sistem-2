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
        public static string provincia_dir = "file_provincia.txt";
        public static string municipio_dir = "file_municipio.txt";
        public static string barrio_dir = "file_barrio.txt";
        public static string urbanizacion_dir = "file_urbanizacion.txt";
        public static string distrito_municipal_dir = "file_distrito_municipal.txt";
        public static string seccion_dm_dir = "file_seccion_dm.txt";
        public static string barrio_dm_dir = "file_barrio_dm.txt";
        public static string urbanizacion_dm_dir = "file_urbanizacion_dm.txt";
        public static string persona_dir = "file_persona.txt";

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

        public static string[] fileToStringArray(string dir)
        {
            string[] lines = File.ReadAllLines("file.txt");
            return lines;
        }

        public static string fileToString(string dir)
        {
            string content = File.ReadAllText(dir);
            return content;
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
            string line = null;
            string line_to_delete = id.ToString();
            string id_file;
            string copy_file_name = "copy" + dir;
            string copy = "";
            using (StreamReader reader = new StreamReader(dir))
            {
                using (StreamWriter writer = new StreamWriter(copy_file_name))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        id_file = line.Split(Utilities.sep)[0];
                        if (String.Compare(id_file, id.ToString()) == 0)
                            continue;
                        writer.WriteLine(line);
                    }
                }
            }
            copy = fileToString(copy_file_name);
            File.Delete(copy_file_name);
            File.WriteAllText(dir, String.Empty);
            File.WriteAllText(dir, copy);
        }

        public static void updateFromFileById(string dir, int id, string modification)
        {
            string line = null;
            string line_to_delete = id.ToString();
            string id_file;
            string copy_file_name = "copy" + dir;
            string copy = "";
            using (StreamReader reader = new StreamReader(dir))
            {
                using (StreamWriter writer = new StreamWriter(copy_file_name))
                {
                    while ((line = reader.ReadLine()) != null)
                    {
                        id_file = line.Split(Utilities.sep)[0];
                        if (String.Compare(id_file, id.ToString()) == 0)
                        {
                            writer.WriteLine(modification);
                        }  
                        else
                        {
                            writer.WriteLine(line);
                        }
                        
                    }
                }
            }
            copy = fileToString(copy_file_name);
            File.Delete(copy_file_name);
            File.WriteAllText(dir, String.Empty);
            File.WriteAllText(dir, copy);
        }

        public static List<String> readIdsFromFile(string dir)
        {
            string line;
            string id;
            List<string> lista = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(dir);
            while ((line = file.ReadLine()) != null)
            {
                id = line.Split(Utilities.sep)[0];
                lista.Add(id);
            }
            file.Close();
            return lista;
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
                for (int i = 0; i < values.Length; i++)
                {
                    dr[i] = values[i];
                }
                dt.Rows.Add(dr);
            }
            file.Close();
            return dt;
        }

        public static List<string> getPersonByNameFromFile(string name)
        {
            string dir = Utilities.persona_dir;
            string line;
            string[] line_split;
            List<string> lista = new List<string>();
            System.IO.StreamReader file = new System.IO.StreamReader(dir);
            while ((line = file.ReadLine()) != null)
            {
                // name column 1
                line_split = line.Split(Utilities.sep);
                if(line_split[1] == name)
                    lista.Add(line);
            }
            file.Close();
            return lista;
        }

        public static List<string> filterListByPersonName(List<string> lista, string filter)
        {
            List<string> list_filted = new List<string>();
            string []array_splited;
            foreach (string line in lista)
            {
                array_splited = line.Split(Utilities.sep);
                if (array_splited[1] == filter)
                    list_filted.Add(line);
            }
            return list_filted;
        }

        public static List<string> filterListByPersonApellido(List<string> lista, string filter)
        {
            List<string> list_filted = new List<string>();
            string[] array_splited;
            foreach (string line in lista)
            {
                array_splited = line.Split(Utilities.sep);
                if (array_splited[2] == filter)
                    list_filted.Add(line);
            }
            return list_filted;
        }

        public static List<string> filterListByPersonSexo(List<string> lista, char filter)
        {
            filter = char.ToLower(filter);
            List<string> list_filted = new List<string>();
            string[] array_splited;
            foreach (string line in lista)
            {
                array_splited = line.Split(Utilities.sep);
                if (array_splited[3] == filter.ToString())
                    list_filted.Add(line);
            }
            return list_filted;
        }

        public static List<string> filterListByPersonEstadoCivl(List<string> lista, string filter)
        {
            List<string> list_filted = new List<string>();
            string[] array_splited;
            foreach (string line in lista)
            {
                array_splited = line.Split(Utilities.sep);
                if (array_splited[5] == filter.ToString())
                    list_filted.Add(line);
            }
            return list_filted;
        }

        public static List<string> filterListByPersonAge(List<string> lista, int edad, Dictionary<string,bool> dic)
        {
            string opcion="";
            if (dic["ismayor"] == true)
                opcion = "mayor";
            if (dic["ismenor"] == true)
                opcion = "menor";
            if (dic["equal"] == true)
                opcion = "equal";
            List<string> list_filted = new List<string>();
            string[] array_splited;
            DateTime now = DateTime.Today;
            DateTime string_to_date;
            int calculated_age;
            foreach (string line in lista)
            {
                array_splited = line.Split(Utilities.sep);
                string_to_date = DateTime.Parse(array_splited[4]);
                calculated_age = now.Year - string_to_date.Year;
                //Console.WriteLine(calculated_age);
                if (opcion == "mayor")
                {
                    if (calculated_age > edad)
                    {
                        list_filted.Add(line);
                    }
                }
                if (opcion == "menor")
                {
                    if (calculated_age < edad)
                    {
                        list_filted.Add(line);
                    }
                }
                if (opcion == "equal")
                {
                    if (calculated_age == edad)
                    {
                        list_filted.Add(line);
                    }
                }      
            }
            return list_filted;
        }

        public static List<string> filterListByPersonOcupacion(List<string> lista, string filter)
        {
            List<string> list_filted = new List<string>();
            string[] array_splited;
            foreach (string line in lista)
            {
                array_splited = line.Split(Utilities.sep);
                if (array_splited[6] == filter.ToString())

                    list_filted.Add(line);
            }
            return list_filted;
        }

        public static bool checkExitsRecordById(int id, string dir)
        {
            List<string> lista_id = new List<string>();
            lista_id = readIdsFromFile(dir);
            return lista_id.Contains(id.ToString());
        }

        public static void print_lista(List<string> lista)
        {
            foreach (object element in lista)
            {
                Console.WriteLine(element);
            }
        }
        
    }
}
