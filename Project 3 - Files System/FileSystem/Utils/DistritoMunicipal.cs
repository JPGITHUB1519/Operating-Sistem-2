using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class DistritoMunicipal
    {
        int iddistrito;
        string nombre;
        string localizacion;
        float area;
        string punto_cardinal;
        int idprovincia;

        public int Iddistrito
        {
            get { return iddistrito; }
            set { iddistrito = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Localizacion
        {
            get { return localizacion; }
            set { localizacion = value; }
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

        public int Idprovincia
        {
            get { return idprovincia; }
            set { idprovincia = value; }
        }
    }
}
