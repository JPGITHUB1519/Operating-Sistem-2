using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Municipio
    {
        int idmunicipio;
        string nombre;
        string localizacion;
        float area;
        string punto_cardinal;      
        int idprovincia;

        public int Idmunicipio
        {
            get { return idmunicipio; }
            set { idmunicipio = value; }
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

        public int Idprovincia
        {
            get { return idprovincia; }
            set { idprovincia = value; }
        }

        public void insertarMunicipio(Municipio mun, bool is_editar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.municipio_dir;
            string data = mun.idmunicipio.ToString() + sep + mun.Idprovincia + sep + mun.Nombre + sep + mun.Localizacion + sep + mun.Area.ToString() + sep + mun.Punto_cardinal;
            
            if(is_editar)
                Utilities.updateFromFileById(dir, mun.idmunicipio, data);
            else
                Utilities.writeSingleLineToFile(dir, data);

        }

        public static List<String> filterMunicipio(Dictionary<string, object> dic)
        {
            string columns = "";
            List<string> result = new List<string>();
            List<string> parameters = (List<string>)dic["parameters"];
            //Console.WriteLine("\n**** Parametros ****\n");
            //Utilities.printCollection(parameters);
            List<int> columns_position_infile = new List<int>();
            result = Utilities.readFileByList(Utilities.municipio_dir);
            if (parameters[0] == "*")
            {
                return result;
            }
            else
            {
                if (parameters.Contains("idmunicipio"))
                {
                    columns_position_infile.Add(0);
                }
                if (parameters.Contains("idprovincia"))
                {
                    columns_position_infile.Add(1);
                }
                if (parameters.Contains("nombre"))
                {
                    columns_position_infile.Add(2);
                }
                if (parameters.Contains("location"))
                {
                    columns_position_infile.Add(3);
                }
                if (parameters.Contains("area"))
                {
                    columns_position_infile.Add(4);
                }
                if (parameters.Contains("punto_cardinal"))
                {
                    columns_position_infile.Add(5);
                }
                //Console.WriteLine("\n**** Elementos ****\n\n");
                //Utilities.printCollection(columns_position_infile);
                //Console.WriteLine("\n**** Find elementos ****\n\n");
                result = Utilities.readFileByListSpecified(Utilities.municipio_dir, columns_position_infile);
            }
            return result;
        }

        


    }
}
