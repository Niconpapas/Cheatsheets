using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Modelo.Contexto db = new Modelo.Contexto();
            Logica.Autor objLogicaAutor = new Logica.Autor();

            //// Crear y guardar un Autor 

            //Console.Write("Ingrese Codigo: ");
            //int codigo = (Convert.ToInt32(Console.ReadLine()));

            //Console.Write("Ingrese Apellido: ");
            //string ape = Console.ReadLine();

            //Console.Write("Ingrese Nombre: ");
            //string nombre = Console.ReadLine();


            //Agregar Autores

            //Modelo.Autor objModeloAutor1 = new Modelo.Autor { Apellido = "Borges", Nombre = "Jorge Luis" };
            //objLogicaAutor.Agregar(objModeloAutor1);

            //Modelo.Autor objModeloAutor2 = new Modelo.Autor { Apellido = "Sabato", Nombre = "Hernesto" };
            //objLogicaAutor.Agregar(objModeloAutor2);

            //Modelo.Autor objModeloAutor3 = new Modelo.Autor { Apellido = "Cortazar", Nombre = "Julio" };
            //objLogicaAutor.Agregar(objModeloAutor3);






            //objModeloAutor.ID = codigo;
            //objModeloAutor.Apeliido = ape;
            //objModeloAutor.Nombre = nombre;

            //objLogicaAutor.Agregar(objModeloAutor);

            Console.WriteLine("\nDatos grabados... \n");

            //Console.WriteLine("\n---Lista de Autores---\n");




            foreach (var autor in objLogicaAutor.TraerTodos())
            {
                Console.WriteLine(autor.ID + " " + autor.Apellido + "," + autor.Nombre);
            }

            Console.ReadKey();

        }
    }
}
