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
        int poblacion;        
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

        public int Poblacion
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
