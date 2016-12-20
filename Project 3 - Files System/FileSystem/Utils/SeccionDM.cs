using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class SeccionDM
    {
        int idseccion_dm;
        string nombre;
        long poblacion;        
        float area;
        string punto_cardinal;
        int iddistrito;

        public int Idseccion_dm
        {
            get { return idseccion_dm; }
            set { idseccion_dm = value; }
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

        public int Iddistrito
        {
            get { return iddistrito; }
            set { iddistrito = value; }
        }

        public void insertarSeccionDM(SeccionDM sec_dm, bool is_editar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.seccion_dm_dir;
            string data = (sec_dm.idseccion_dm.ToString() + sep + sec_dm.iddistrito.ToString() + sep + sec_dm.nombre + sep + sec_dm.poblacion + sep + sec_dm.area + sep + sec_dm.punto_cardinal);
            if(is_editar)
                Utilities.updateFromFileById(dir, sec_dm.idseccion_dm, data);
            else
                Utilities.writeSingleLineToFile(dir, data);
        }

        public static List<String> filterSeccionDM(Dictionary<string, object> dic)
        {
            string columns = "";
            List<string> result = new List<string>();
            List<string> parameters = (List<string>)dic["parameters"];
            //Console.WriteLine("\n**** Parametros ****\n");
            //Utilities.printCollection(parameters);
            List<int> columns_position_infile = new List<int>();
            result = Utilities.readFileByList(Utilities.seccion_dm_dir);
            if (parameters[0] == "*")
            {
                return result;
            }
            else
            {
                if (parameters.Contains("idseccion_dm"))
                {
                    columns_position_infile.Add(0);
                }
                if (parameters.Contains("iddistrito"))
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
                result = Utilities.readFileByListSpecified(Utilities.seccion_dm_dir, columns_position_infile);
            }
            return result;
        }

    }
}
