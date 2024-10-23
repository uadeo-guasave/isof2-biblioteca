using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Editorial
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Pais { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }
        public string SitioWeb { get; set; }

        // para manejo interno de EF
        public List<Libro> Libros { get; set; }
    }
}
