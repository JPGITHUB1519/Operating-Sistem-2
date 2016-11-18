using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("persona");
            string name = "jean";
            string apellido = "urena";
            char sexo = 'm';
            string estato_civil = "soltero/a";
            string ocupacion = "informatico";
            int edad = 5;
            Dictionary<string, bool> dic = new Dictionary<string,bool>();
            dic.Add("ismayor", true);
            dic.Add("ismenor", false);
            dic.Add("equal", false);
            List<string> lista = new List<string>();
            lista = Utilities.readFileByList(Utilities.persona_dir);
            lista = Utilities.filterListByPersonName(lista, name);
            lista = Utilities.filterListByPersonApellido(lista, apellido);
            lista = Utilities.filterListByPersonSexo(lista, sexo);
            lista = Utilities.filterListByPersonEstadoCivl(lista, estato_civil);
            lista = Utilities.filterListByPersonOcupacion(lista, ocupacion);
            lista = Utilities.filterListByPersonAge(lista, edad, dic);
            Utilities.print_lista(lista);
            Console.ReadKey();
        }
    }
}
