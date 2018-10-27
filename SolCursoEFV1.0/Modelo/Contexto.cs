using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Contexto:DbContext //Clase Necesaria para crear la Base de Datos
    {
        public Contexto():base("CadenaConexion")
        { }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Autor> Autores { get; set; }


    }
}
