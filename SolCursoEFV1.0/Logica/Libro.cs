using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Libro
    {
        Datos.Libro objDatosLibro = new Datos.Libro();
       
        public void Agregar(Modelo.Libro pLibro)
        {
            objDatosLibro.Agregar(pLibro);
        }

        public List<Modelo.Libro> TraerTodos()
        {
            return objDatosLibro.TraerTodos();
        }

    }
}
