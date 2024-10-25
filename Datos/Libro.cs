using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Isbn { get; set; }
        public string Idioma { get; set; }
        public string GeneroLiterario { get; set; }
        public int NumeroDePaginas { get; set; }
        public int EditorialId { get; set; }

        // para manejo interno de EF
        public List<Autor> Autores { get; set; }
        public Editorial Editorial { get; set; }
        public List<Prestamo> Prestamos { get; set; }
    }
}
