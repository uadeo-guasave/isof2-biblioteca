using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class LibroAutor
    {
        public int LibroId { get; set; }
        public int AutorId { get; set; }

        // para manejo interno de EF
        public Libro Libro { get; set; }
        public Autor Autor { get; set; }
    }
}
