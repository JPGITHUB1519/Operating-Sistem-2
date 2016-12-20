using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class BarrioDM
    {
        int idbarrio_dm;
        string nombre;
        long poblacion;
        float area;
        string punto_cardinal;
        int iddistrito;

        public int Idbarrio_dm
        {
            get { return idbarrio_dm; }
            set { idbarrio_dm = value; }
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

        public void insertarBarrioDM(BarrioDM ba_dm, bool is_editar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.barrio_dm_dir;
            string data = (ba_dm.Idbarrio_dm.ToString() + sep + ba_dm.iddistrito.ToString() + sep + ba_dm.nombre + sep + ba_dm.poblacion + sep + ba_dm.area + sep + ba_dm.punto_cardinal);
            if (is_editar)
                Utilities.updateFromFileById(dir, ba_dm.idbarrio_dm, data);
            else
                Utilities.writeSingleLineToFile(dir, data);
        }

        public static List<String> filterBarrioDM(Dictionary<string, object> dic)
        {
            string columns = "";
            List<string> result = new List<string>();
            List<string> parameters = (List<string>)dic["parameters"];
            //Console.WriteLine("\n**** Parametros ****\n");
            //Utilities.printCollection(parameters);
            List<int> columns_position_infile = new List<int>();
            result = Utilities.readFileByList(Utilities.barrio_dm_dir);
            if (parameters[0] == "*")
            {
                return result;
            }
            else
            {
                if (parameters.Contains("idbarrio_dm"))
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
                result = Utilities.readFileByListSpecified(Utilities.barrio_dm_dir, columns_position_infile);
            }
            return result;
        }
    }
}
