using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class PrestamoLibro
    {
        public int PrestamoId { get; set; }
        public int LibroId { get; set; }
        public string Condiciones { get; set; }

        // para el manejo interno de EF
        public Prestamo Prestamo { get; set; }
        public Libro Libro { get; set; }
    }
}
