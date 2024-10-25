using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Prestamo
    {
        public int Id { get; set; }
        public DateTime FechaDeSalida { get; set; }
        public DateTime FechaDeRegreso { get; set; }
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }

        // para manejo interno de EF
        public Usuario Bibliotecario { get; set; }
        public Cliente Cliente { get; set; }
        public List<Libro> Libros { get; set; }
    }
}
