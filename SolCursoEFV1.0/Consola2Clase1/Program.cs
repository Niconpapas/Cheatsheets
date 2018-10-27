using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola2Clase1
{
    class Program
    {
        static void Main(string[] args)
        {
            Logica.Autor objLogicaAutor = new Logica.Autor();
            Logica.Libro objLogicaLibro = new Logica.Libro();

            //var objLibro = new Modelo.Libro { ISBN = 3131, Titulo = "Sobre heroes y tumbas", Anio = 1985 };
            //objLogicaLibro.Agregar(objLibro);

            //var objLibro2 = new Modelo.Libro { ISBN = 2121311, Titulo = "El Tunel", Anio = 1983 };
            //objLogicaLibro.Agregar(objLibro2);

            //var objLibro3 = new Modelo.Libro { ISBN = 2121455311, Titulo = "El Hacedor", Anio = 1986 };
            //objLogicaLibro.Agregar(objLibro3);

            //var objLibro4 = new Modelo.Libro { ISBN = 2121455311, Titulo = "Cien años de Soledad", Anio = 1967, Autores = objLogicaAutor.TraerTodos() };
            //objLogicaLibro.Agregar(objLibro4);



            Console.WriteLine("\n----Libros Agregados----\n");

            Console.WriteLine("\n---Lista de Libros---\n");
            foreach (var libros in objLogicaLibro.TraerTodos())
            {
                Console.WriteLine(libros.ISBN + " " + libros.Titulo + " " + libros.Anio);
                foreach (var autor in libros.Autores)
                {
                    Console.WriteLine("\nAutores:");
                    Console.WriteLine(autor.Apeliido + "," + autor.Nombre);
                }
            }

            Console.Read();



        }
    }
}
