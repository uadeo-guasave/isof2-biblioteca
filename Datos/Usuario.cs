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
        public TipoDeUsuario Tipo { get; set; } // Administrador, Normal, Contador

        // para manejo interno de EF
        public List<Prestamo> Prestamos { get; set; }
    }
}

public enum TipoDeUsuario
{
    Administrador=3, Normal=1, Contador=2
}