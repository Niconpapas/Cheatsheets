using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Autor
    {
        Modelo.Contexto db = new Modelo.Contexto();

        public void Agregar(Modelo.Autor pAutor)
        {
            db.Autores.Add(pAutor);//Agregar a la memoria

            db.SaveChanges();//Agregar a la BD

        }

        public List<Modelo.Autor> TraerTodos()
        {
            Modelo.Contexto db = new Modelo.Contexto();

            return db.Autores.ToList();
            
        }

        //public List<Modelo.Autor> TraerTodosLambda()
        //{
        //    Modelo.Contexto db = new Modelo.Contexto();

        //    List<Modelo.Autor> lista = db.Autores.ToList();

        //    return lista;

        //}

        public List<Modelo.Autor> TraerTodos(string pLetra)
        {
            //LINQ
            List<Modelo.Autor> lista = (from a in db.Autores
                                        where a.Apellido.Contains(pLetra)
                                        select a).ToList();

            return lista;
        }
       
        public void Modificar(Modelo.Autor pAutor)
        {
            //LINQ
            var autor = (from a in db.Autores
                         where a.ID.Equals(pAutor.ID)
                         select a).Single(); //el Single es para que traiga uno(redundante :P pero necesario)

            autor.ID = pAutor.ID;
            autor.Nombre = pAutor.Nombre;
            autor.Apellido = pAutor.Apellido;

            
            db.SaveChanges();
        }

        public void ModificarLambda(Modelo.Autor pAutor)
        {
            var autor = db.Autores.Find(pAutor.ID);

            autor.ID = pAutor.ID;
            autor.Nombre = pAutor.Nombre;
            autor.Apellido = pAutor.Apellido;


            db.SaveChanges();
        }
    
        public void Borrar(int pID)
        {
            //LINQ
            Modelo.Autor autor = db.Autores.Find(pID);
            db.Autores.Remove(autor);
            db.SaveChanges();
        }


    }
}
