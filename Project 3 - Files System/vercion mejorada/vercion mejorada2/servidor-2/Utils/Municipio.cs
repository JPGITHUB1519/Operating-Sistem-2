using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Municipio
    {
        int idmunicipio;
        string nombre;
        string localizacion;
        float area;
        string punto_cardinal;      
        int idprovincia;

        public int Idmunicipio
        {
            get { return idmunicipio; }
            set { idmunicipio = value; }
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

        public void insertarMunicipio(Municipio mun, bool is_editar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.municipio_dir;
            string data = mun.idmunicipio.ToString() + sep + mun.Idprovincia + sep + mun.Nombre + sep + mun.Localizacion + sep + mun.Area.ToString() + sep + mun.Punto_cardinal;
            
            if(is_editar)
                Utilities.updateFromFileById(dir, mun.idmunicipio, data);
            else
                Utilities.writeSingleLineToFile(dir, data);

        }


    }
}
