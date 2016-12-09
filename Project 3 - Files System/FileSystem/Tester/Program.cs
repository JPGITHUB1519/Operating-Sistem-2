using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace Tester
{
    class Program
    {
        /*
         //string texto = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam ut sapien tortor.";
            string texto = "jean";
            string encrypted = Encrypt.encriptar(texto);
            Console.WriteLine(encrypted);
            encrypted = Encrypt.desencriptar(encrypted);
            Console.WriteLine("\n\n" + encrypted);
            Console.ReadKey();
         * */


        /*
           string aux_query;
           int ant_space;
           int next_space;
           query = query.ToLower();
           next_space = query.IndexOf(' ');
           ant_space = next_space;
           command = query.Substring(0, next_space);
           if (query.IndexOf("distinct") != -1 || query.IndexOf("all") != -1)
           {
               next_space = query.IndexOf(' ', ant_space);
               universal_filter = query.Substring(ant_space + 1, next_space - 2);
               ant_space = next_space;
           }
           Console.WriteLine(command);
           Console.WriteLine(universal_filter);
           //string [] splited = query.Split(' ');
           //Utilities.printCollection(splited);
           */

        static void Main(string[] args)
        {
            /* sql query stuffs
            string command;
            string universal_filter = "";
            string table = "";
            List<string> parameters = new List<string>();
            bool end_parameters = false;
            int pos_finished_parameters = 0;
            string[] splited;
            string query = "Select distinct idprovincia, nombre, localizacion from provincia where idprovincia = 1";
            query = query.ToLower();
            splited = query.Split(' ');
            //Utilities.printCollection(splited);
            int cont = 0;
            command = splited[0];

            for (int i = 0; i < splited.Length; i++)
            {
                if (i == 0)
                {
                    command = splited[0];
                }
                if (i == 1)
                {
                    if (splited[i] == "distinct" || splited[i] == "all")
                    {
                        universal_filter = splited[i];
                        end_parameters = true;
                        continue;
                    }
                }

                if (i == 1 || end_parameters == true)
                {
                    if (splited[i] != "from")
                    {
                        parameters.Add(splited[i].Replace(',', ' '));
                    }
                    else
                    {
                        end_parameters = false;
                        pos_finished_parameters = i;
                    }
                }

                if (i == pos_finished_parameters + 1)
                {
                    table = splited[pos_finished_parameters + 1];
                }
   
                
            }

            Console.WriteLine(command);
            Console.WriteLine(universal_filter);
            Utilities.printCollection(parameters);
            Console.WriteLine(table);
             * 
            */

            /*
            List<string> lista = new List<string>();
            Dictionary<string, string> filter = new Dictionary<string, string>();
            filter.Add("isfilted", "false");
            lista = Provincia.filterProvincia(filter);
            Console.WriteLine(lista.Count);
            Utilities.printCollection(lista);
            Console.ReadKey();
            */



            string query = "Select idprovincia, area from provincia where idprovincia = 1";
            query = query.ToLower();
            Dictionary<string, object> filters = new Dictionary<string, object>();
            filters = Utilities.selectQueryReader(query);   
            List<string> result;
            result = Provincia.filterProvincia(filters);
            Utilities.printCollection(result);
            Console.ReadKey();

            /*
            string query = "Select distinct idprovincia, nombre from provincia where idprovincia = 1";
            List<string> result = Utilities.getParametersQuery(query);
            result = Utilities.comma_quitter(result);
            Utilities.printCollection(result);
            Console.ReadKey();
            */

            /*
             * ENcriptar
            Encrypt.encriptarArchivo("file_municipio.txt");
            Console.WriteLine(Encrypt.desencriptarArchivo("encripted_file_municipio.txt"));
            Console.ReadKey();
             * */

            /*
            List<int> lista = new List<int>();
            List<string> lista_register = new List<string>();
            lista.Add(0);
            lista.Add(1);
            lista.Add(2);
            lista_register = Utilities.readFileByListSpecified(Utilities.provincia_dir, lista);
            Utilities.printCollection(lista_register);
            Console.ReadKey();
            */

        }
    }
    /*
         * 
         * queryReader usage sample
        string query = "Select distinct idprovincia, nombre, localizacion from provincia where idprovincia = 1";
        Dictionary<string, object> filters = new Dictionary<string, object>();
        filters = Utilities.selectQueryReader(query);
        Console.WriteLine(filters["command"]);
        Console.WriteLine(filters["universal_filter"]);
        List<string> parameters = new List<string>();
        parameters = (List<string>)filters["parameters"];
        Utilities.printCollection(parameters);
        Console.ReadKey();
        */
}
