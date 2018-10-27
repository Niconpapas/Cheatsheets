using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class Autor
    {
        Datos.Autor objDatosAutor = new Datos.Autor();

        public void Agregar(Modelo.Autor pAutor)
        {
            objDatosAutor.Agregar(pAutor);
        }

        public List<Modelo.Autor> TraerTodos()
        {
            return objDatosAutor.TraerTodos();
        }

        public void Modificar(Modelo.Autor pAutor)
        {
            objDatosAutor.Modificar(pAutor);
        }

        public void Borrar(int pIDAutor)
        {
            objDatosAutor.Borrar(pIDAutor);
        }

        public List<Modelo.Autor> TraerTodos(string pLetras)
        {
            return objDatosAutor.TraerTodos(pLetras);
        }

    }
}
