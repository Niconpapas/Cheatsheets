using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // 10 nombres
            string[] vecNombres = {"Franco","Facundo","jorge","jonathan","luciano","lucas","fernando","leonardo","gonzalo","ignacio","sebastian"};

            //LINQ
            Console.WriteLine("---LINQ---\n");
            //Buscar el primer elemento que empiece con "jo"
            var nombre = (from a in vecNombres
                          where a.StartsWith("jo")
                          select a).FirstOrDefault();

            Console.WriteLine(nombre.ToString());

            //Todos los nombres que contengan na 
            var lista = (from a in vecNombres
                         where a.Contains("na")
                         select a).ToList();

            foreach (var item in lista)
            {
                Console.WriteLine(item);

            }
            Console.WriteLine("\n------\n");

            //LAMBDA
            Console.WriteLine("---LAMBDA---\n");

            //Buscar el primer elemento que empiece con "jo"
            string strNombre = Array.Find(vecNombres, n => n.StartsWith("jo"));
            Console.WriteLine(strNombre);

            string[] strNombres = Array.FindAll(vecNombres, n => n.Contains("na"));

            Console.WriteLine("\n");

            Console.WriteLine("alumnos que contengan na\n");
            foreach (var item in strNombres)
            {
                Console.WriteLine(item);

            }


            Console.ReadKey();

        }
    }
}
