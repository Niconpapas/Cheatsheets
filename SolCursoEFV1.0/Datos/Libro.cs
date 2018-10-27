using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Libro
    {
        Modelo.Contexto db = new Modelo.Contexto();

        public void Agregar(Modelo.Libro pLibro)
        {
            db.Libros.Add(pLibro);

            db.SaveChanges();
        }

        public List<Modelo.Libro> TraerTodos()
        {
            return db.Libros.ToList();
        }
    }
}
