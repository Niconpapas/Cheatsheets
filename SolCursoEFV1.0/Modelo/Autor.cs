using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 


namespace Modelo
{
   // [Table("Autores")]
    public class Autor
    {
        [Key]
        public int ID { get; set; } //Ya sabe que es Primary Key Solo si no tiene codigo, en ese caso hay que aclarar IDLibro

        [MaxLength(200)]
        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public List<Modelo.Libro> Libros { get; set; }
    }
}
