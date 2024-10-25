using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Curp { get; set; }
        public string Ine { get; set; }
        public string Telefono { get; set; }
        public string CorreoElectronico { get; set; }

        // para manejo interno de EF
        public List<Prestamo> Prestamos { get; set; }
    }
}
