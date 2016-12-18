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
    }
}
