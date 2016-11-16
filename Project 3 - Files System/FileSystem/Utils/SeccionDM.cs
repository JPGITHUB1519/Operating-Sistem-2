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

        public void insertarSeccionDM(SeccionDM sec_dm)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.seccion_dm_dir;
            string data = (sec_dm.idseccion_dm.ToString() + sep + sec_dm.iddistrito.ToString() + sep + sec_dm.nombre + sep + sec_dm.poblacion + sep + sec_dm.area + sep + sec_dm.punto_cardinal);
            Utilities.writeSingleLineToFile(dir, data);
        }

    }
}
