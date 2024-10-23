namespace Datos
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Alias { get; set; }
        public string Contraseña { get; set; }
        public string CorreoElectronico { get; set; }
        public string Recordatorio { get; set; }
        public string Telefono { get; set; }

        // para manejo interno de EF
        public List<Prestamo> Prestamos { get; set; }
    }
}
