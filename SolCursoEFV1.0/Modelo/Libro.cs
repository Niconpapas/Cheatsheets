using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    //[Table("Libros")]
    public class Libro
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ISBN { get; set; }//Ya sabe que es clave primaria, ID en cualquier lado del nombre

        [MaxLength(200)]
        public string Titulo { get; set; }


        public int Anio { get; set; }
        public List<Autor> Autores { get; set; }
    }
}
