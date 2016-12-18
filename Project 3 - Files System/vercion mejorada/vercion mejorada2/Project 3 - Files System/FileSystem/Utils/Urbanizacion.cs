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
    }
}
