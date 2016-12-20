using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utils
{
    public class Persona
    {
        int idpersona;

        public int Idpersona
        {
            get { return idpersona; }
            set { idpersona = value; }
        }

        string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        char sexo;

        public char Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        string fecha_nacimiento;

        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        string estado_civil;

        public string Estado_civil
        {
            get { return estado_civil; }
            set { estado_civil = value; }
        }
        bool is_vivo;

        public bool Is_vivo
        {
            get { return is_vivo; }
            set { is_vivo = value; }
        }
        string ocupacion;

        public string Ocupacion
        {
            get { return ocupacion; }
            set { ocupacion = value; }
        }
        int idbarrio;

        public int Idbarrio
        {
            get { return idbarrio; }
            set { idbarrio = value; }
        }
        int idurbanizacion;

        public int Idurbanizacion
        {
            get { return idurbanizacion; }
            set { idurbanizacion = value; }
        }
        int idseccion;

        public int Idseccion
        {
            get { return idseccion; }
            set { idseccion = value; }
        }
        int idbarrio_dm;

        public int Idbarrio_dm
        {
            get { return idbarrio_dm; }
            set { idbarrio_dm = value; }
        }
        int idseccion_dm;

        public int Idseccion_dm
        {
            get { return idseccion_dm; }
            set { idseccion_dm = value; }
        }
        int idurbanizacion_dm;

        public int Idurbanizacion_dm
        {
            get { return idurbanizacion_dm; }
            set { idurbanizacion_dm = value; }
        }

        int iddistrito_municipal;

        public int Iddistrito_municipal
        {
            get { return iddistrito_municipal; }
            set { iddistrito_municipal = value; }
        }

        public void insertarPersona(Persona per, bool iseditar = false)
        {
            char sep = Utils.Utilities.sep;
            string dir = Utilities.persona_dir;
            string data = per.idpersona.ToString() + sep 
                   + per.nombre + sep 
                   + per.apellido + sep 
                   + per.sexo + sep 
                   + per.fecha_nacimiento + sep 
                   + per.estado_civil + sep 
                   + per.ocupacion + sep 
                   + per.idbarrio.ToString() + sep 
                   + per.idurbanizacion.ToString() + sep
                   + per.idseccion_dm.ToString() + sep
                   + per.idbarrio_dm.ToString() + sep
                   + per.idurbanizacion_dm.ToString() + sep
                   + per.iddistrito_municipal.ToString() + sep
                   + per.is_vivo.ToString();
            if (iseditar)
                Utilities.updateFromFileById(dir, per.idpersona, data);
            else
                Utilities.writeSingleLineToFile(dir, data);
        }

        public static List<String> filterPersona(Dictionary<string, object> dic)
        {
            string columns = "";
            List<string> result = new List<string>();
            List<string> parameters = (List<string>)dic["parameters"];
            //Console.WriteLine("\n**** Parametros ****\n");
            //Utilities.printCollection(parameters);
            List<int> columns_position_infile = new List<int>();
            result = Utilities.readFileByList(Utilities.persona_dir);
            if (parameters[0] == "*")
            {
                return result;
            }
            else
            {
                if (parameters.Contains("idpersona"))
                {
                    columns_position_infile.Add(0);
                }
                if (parameters.Contains("nombre"))
                {
                    columns_position_infile.Add(1);
                }
                if (parameters.Contains("apellido"))
                {
                    columns_position_infile.Add(2);
                }
                if (parameters.Contains("sexo"))
                {
                    columns_position_infile.Add(3);
                }
                if (parameters.Contains("fecha_nacimiento"))
                {
                    columns_position_infile.Add(4);
                }
                if (parameters.Contains("estado_civil"))
                {
                    columns_position_infile.Add(5);
                }
                if (parameters.Contains("ocupacion"))
                {
                    columns_position_infile.Add(6);
                }
                if (parameters.Contains("idbarrio"))
                {
                    columns_position_infile.Add(7);
                }
                if (parameters.Contains("idurbanizacion"))
                {
                    columns_position_infile.Add(8);
                }
                if (parameters.Contains("idseccion_dm"))
                {
                    columns_position_infile.Add(9);
                }
                if (parameters.Contains("idbarrio_dm"))
                {
                    columns_position_infile.Add(10);
                }
                if (parameters.Contains("idurbanizacion_dm"))
                {
                    columns_position_infile.Add(11);
                }
                if (parameters.Contains("idistrito_municipal"))
                {
                    columns_position_infile.Add(12);
                }
                if (parameters.Contains("isvivo"))
                {
                    columns_position_infile.Add(13);
                }
                //Console.WriteLine("\n**** Elementos ****\n\n");
                //Utilities.printCollection(columns_position_infile);
                //Console.WriteLine("\n**** Find elementos ****\n\n");
                result = Utilities.readFileByListSpecified(Utilities.persona_dir, columns_position_infile);
            }
            return result;
        }

        
    }
}
