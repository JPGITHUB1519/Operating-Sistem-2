using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class UrbanizacionDM
    {
        int idurbanizacion_dm;
        string nombre;
        long poblacion;
        float area;
        string punto_cardinal;
        int iddistrito;

        public int Idurbanizacion_dm
        {
            get { return idurbanizacion_dm; }
            set { idurbanizacion_dm = value; }
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

        public void insertarUrbanizacionDM(UrbanizacionDM urb_dm, bool is_editar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.urbanizacion_dm_dir;
            string data = (urb_dm.idurbanizacion_dm.ToString() + sep + urb_dm.iddistrito.ToString() + sep + urb_dm.nombre + sep + urb_dm.poblacion + sep + urb_dm.area + sep + urb_dm.punto_cardinal);
            if (is_editar)
                Utilities.updateFromFileById(dir, urb_dm.idurbanizacion_dm, data);
            else
                Utilities.writeSingleLineToFile(dir, data);
        }
        
    }
}
