using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Autor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }

        // para manejo interno de EF
        public List<LibroAutor> LibrosAutores { get; set; }
    }
}
