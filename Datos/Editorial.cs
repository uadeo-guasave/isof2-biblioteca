using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    [Table("Editoriales")]
    public class Editorial
    {
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Nombre { get; set; }

        [MaxLength(100)]
        public string? Pais { get; set; }

        [MaxLength(30)]
        public string? Telefono { get; set; }

        [EmailAddress]
        public string? CorreoElectronico { get; set; }

        [Url]
        public string? SitioWeb { get; set; }

        // para manejo interno de EF
        [NotMapped]
        public List<Libro> Libros { get; set; }
    }
}
