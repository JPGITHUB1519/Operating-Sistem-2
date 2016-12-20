using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Urbanizacion
    {
        int idurbanizacion;
        string nombre;
        long poblacion;
        float area;
        string punto_cardinal;
        int idmunicipio;

        

        public int Idurbanizacion
        {
            get { return idurbanizacion; }
            set { idurbanizacion = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public long Poblacion
        {
            get { return poblacion; }
            set { poblacion = value; }
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

        public int Idmunicipio
        {
            get { return idmunicipio; }
            set { idmunicipio = value; }
        }

        public void insertarUrbanizacion(Urbanizacion urb, bool is_editar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.urbanizacion_dir;
            string data = (urb.idurbanizacion.ToString() + sep + urb.idmunicipio.ToString() + sep + urb.nombre + sep + urb.poblacion + sep + urb.area + sep + urb.punto_cardinal);
            if(is_editar)
                Utilities.updateFromFileById(dir, urb.idurbanizacion, data);
            else
                Utilities.writeSingleLineToFile(dir, data);
        }

        public static List<String> filterUrbanizacion(Dictionary<string, object> dic)
        {
            string columns = "";
            List<string> result = new List<string>();
            List<string> parameters = (List<string>)dic["parameters"];
            //Console.WriteLine("\n**** Parametros ****\n");
            //Utilities.printCollection(parameters);
            List<int> columns_position_infile = new List<int>();
            result = Utilities.readFileByList(Utilities.urbanizacion_dir);
            if (parameters[0] == "*")
            {
                return result;
            }
            else
            {
                if (parameters.Contains("idurbanizacion"))
                {
                    columns_position_infile.Add(0);
                }
                if (parameters.Contains("idmunicipio"))
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
                result = Utilities.readFileByListSpecified(Utilities.urbanizacion_dir, columns_position_infile);
            }
            return result;
        }
    }
}
