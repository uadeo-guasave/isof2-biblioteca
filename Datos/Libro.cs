using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    [Table("Libros")]
    public class Libro
    {
        public int Id { get; set; }

        [Required, MaxLength(300)]
        public string Titulo { get; set; }

        [Required, MaxLength(16)]
        public string Isbn { get; set; }

        [MaxLength(100)]
        public string? Idioma { get; set; }

        [MaxLength(100)]
        public string? GeneroLiterario { get; set; }
        public int? NumeroDePaginas { get; set; }

        // FK_TablaActual_TablaRelacionada_ColumnaRelacionada
        [Required, ForeignKey("FK_Libros_Editoriales_Id")]
        public int EditorialId { get; set; }

        // para manejo interno de EF
        [NotMapped]
        public Editorial Editorial { get; set; }

        // public List<Autor> Autores { get; set; }
        // public List<Prestamo> Prestamos { get; set; }
    }
}
