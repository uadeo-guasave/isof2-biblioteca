// string nombre = txtNombre.text;
// var asigna tipo de dato por inferencia
// toma el tipo de dato al inicializarse
using Datos;

var usuario = new Usuario();
usuario.Alias = "user1";
usuario.Contraseña = "123456";
usuario.CorreoElectronico = "mi@correo.com";
usuario.Telefono = "6870000000";

var autor1 = new Autor
{
    Id = 1,
    Nombre = "Autor",
    Apellidos = "Uno"
};

var autor2 = new Autor
{
    Id = 2,
    Nombre = "Autor",
    Apellidos = "Dos"
};

var autor3 = new Autor
{
    Id = 3,
    Nombre = "Autor",
    Apellidos = "Tres"
};

var editorial1 = new Editorial
{
    Id = 1,
    Nombre = "Editorial Uno"
};

var editorial2 = new Editorial
{
    Id = 2,
    Nombre = "Editorial Dos"
};

// libro1 = autor1 y autor2, editorial1
var libro1 = new Libro
{
    Id = 1,
    Titulo = "Libro Uno",
    EditorialId = editorial1.Id,
    Editorial = editorial1
};
// libro2 = autor3, editorial2
var libro2 = new Libro
{
    Id = 2,
    Titulo = "Libro Dos",
    EditorialId = editorial2.Id,
    Editorial = editorial2
};

var libro1Autor1 = new LibroAutor
{
    LibroId = libro1.Id,
    AutorId = autor1.Id
}; // 1, 1

var libro1Autor2 = new LibroAutor
{
    LibroId = libro1.Id,
    AutorId = autor2.Id
}; // 1, 2

var libro2Autor3 = new LibroAutor
{
    LibroId = libro2.Id,
    AutorId = autor3.Id
}; // 2, 3

// TODO: Convertir a SQL el modelo lógico