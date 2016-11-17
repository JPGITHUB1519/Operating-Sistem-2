using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Utils
{
    public class Provincia
    {
        int idprovincia;
        string nombre;
        string localizacion;
        float area;
        string punto_cardinal;

        public int Idprovincia
        {
            get { return idprovincia; }
            set { idprovincia = value; }
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

        public void insertarProvincia(Provincia prov, bool iseditar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.provincia_dir;
            string data = prov.Idprovincia.ToString() + sep + prov.Nombre + sep + prov.Localizacion + sep + prov.Area.ToString() + sep + prov.Punto_cardinal;
            if(iseditar)
                Utilities.updateFromFileById(dir, prov.idprovincia, data);
            else
                Utilities.writeSingleLineToFile(dir, data);
        }

        /*
        public static List<Provincia> fillListProvinciaFromFile()
        {
            string dir = @"C:\Users\Programador\Desktop\" + Utils.Utilities.dir;
            string line;
            Provincia prov = new Provincia();
            List<Provincia> lista = new List<Provincia>();
            System.IO.StreamReader file = new System.IO.StreamReader(dir);
            while ((line = file.ReadLine()) != null)
            {
                string[] words = line.Split(',');
                prov.Idprovincia = Convert.ToInt32(words[0]);
                prov.Nombre = words[1];
                prov.Localizacion = words[2];
                prov.Area = float.Parse(words[3]);
                prov.Punto_cardinal = words[4];
                lista.Add(prov);
            }

            return lista;
        }
        */


    }
}
