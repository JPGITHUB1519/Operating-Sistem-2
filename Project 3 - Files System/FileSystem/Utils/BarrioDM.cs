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
    }
}
