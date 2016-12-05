using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Utils
{
    public class Provincia
    {
        int idprovincia;
        string nombre;
        string localizacion;
        float area;
        string punto_cardinal;

        public int Idprovincia
        {
            get { return idprovincia; }
            set { idprovincia = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Localizacion
        {
            get { return localizacion; }
            set { localizacion = value; }
        }

        public float Area
        {
            get { return area; }
            set { area = value; }
        }

        public string Punto_cardinal
        {
            get { return punto_cardinal; }
            set { punto_cardinal = value; }
        }

        public void insertarProvincia(Provincia prov, bool iseditar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.provincia_dir;
            string data = prov.Idprovincia.ToString() + sep + prov.Nombre + sep + prov.Localizacion + sep + prov.Area.ToString() + sep + prov.Punto_cardinal;
            if(iseditar)
                Utilities.updateFromFileById(dir, prov.idprovincia, data);
            else
                Utilities.writeSingleLineToFile(dir, data);
        }

        // sql queries filters
        public static List<String> filterProvincia(Dictionary<string, object>dic)
        {
            List<string> result = new List<string>();
            List<string> parameters = (List<string>)dic["parameters"];
            //Console.WriteLine("\n**** Parametros ****\n");
            //Utilities.printCollection(parameters);
            List<int> columns_position_infile = new List<int>();
            result = Utilities.readFileByList(Utilities.provincia_dir);
            if (parameters[0] == "*")
            {
                return result;
            }
            else
            {
                if(parameters.Contains("idprovincia"))
                {
                    columns_position_infile.Add(0);
                }
                if(parameters.Contains("nombre"))
                {
                    columns_position_infile.Add(1);
                }
                if (parameters.Contains("location"))
                {
                    columns_position_infile.Add(2);
                }
                if (parameters.Contains("area"))
                {
                    columns_position_infile.Add(3);
                }
                if (parameters.Contains("punto_cardinal"))
                {
                    columns_position_infile.Add(4);
                }
                //Console.WriteLine("\n**** Elementos ****\n\n");
                //Utilities.printCollection(columns_position_infile);
                //Console.WriteLine("\n**** Find elementos ****\n\n");
                result = Utilities.readFileByListSpecified(Utilities.provincia_dir, columns_position_infile);
            }
            return result;
        }

        /*
        public static List<Provincia> fillListProvinciaFromFile()
        {
            string dir = @"C:\Users\Programador\Desktop\" + Utils.Utilities.dir;
            string line;
            Provincia prov = new Provincia();
            List<Provincia> lista = new List<Provincia>();
            System.IO.StreamReader file = new System.IO.StreamReader(dir);
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                prov.Idprovincia = Convert.ToInt32(words[0]);
                prov.Nombre = words[1];
                prov.Localizacion = words[2];
                prov.Area = float.Parse(words[3]);
                prov.Punto_cardinal = words[4];
                lista.Add(prov);
            }

            return lista;
        }
        */


    }
}
