using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Barrio
    {
        int idbarrio;
        string nombre;
        long poblacion;  
        float area;
        string punto_cardinal;
        int idmunicipio;

        public int Idbarrio
        {
            get { return idbarrio; }
            set { idbarrio = value; }
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

        public void insertarBarrio(Barrio ba, bool is_editar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.barrio_dir;
            string data = (ba.idbarrio.ToString() +  sep + ba.idmunicipio.ToString() + sep + ba.nombre + sep + ba.poblacion +sep + ba.area + sep + ba.punto_cardinal);
            if (is_editar)
                Utilities.updateFromFileById(dir, ba.idbarrio, data);
            else
                Utilities.writeSingleLineToFile(dir, data);
        }
    }
}
