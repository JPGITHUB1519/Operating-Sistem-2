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
        int poblacion;  
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

        public int Idmunicipio
        {
            get { return idmunicipio; }
            set { idmunicipio = value; }
        }
    }
}
