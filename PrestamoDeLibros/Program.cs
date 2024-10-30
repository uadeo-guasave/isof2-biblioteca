// string nombre = txtNombre.text;
// var asigna tipo de dato por inferencia
// toma el tipo de dato al inicializarse
using Datos;

// InicializarBaseDeDatos();
// GuardarAutores();

static void InicializarBaseDeDatos()
{
    var db = new Datos.SqliteDbContext();
    db.Database.EnsureCreated();
}

var usuario = new Usuario();
usuario.Alias = "user1";
usuario.Contraseña = "123456";
usuario.CorreoElectronico = "mi@correo.com";
usuario.Telefono = "6870000000";



static void GuardarAutores()
{
    var autor1 = new Autor
    {
        Nombre = "Autor",
        Apellidos = "Uno"
    };

    var autor2 = new Autor
    {
        Nombre = "Autor",
        Apellidos = "Dos"
    };

    var autor3 = new Autor
    {
        Nombre = "Autor",
        Apellidos = "Tres"
    };
    using (var db = new Datos.SqliteDbContext())
    {
        db.Autores.Add(autor1);
        // INSERT INTO Autores(Nombre, Apellidos) VALUES ('Autor', 'Uno');
        db.Autores.Add(autor2);
        db.Autores.Add(autor3);
        db.SaveChanges();
    }
}

MostrarTodosLosAutores(); 
static void MostrarTodosLosAutores()
{
    using (var db = new Datos.SqliteDbContext())
    {
        // Open()
        var autores = db.Autores.ToList();
        if (autores.Any())
        {
            autores.ForEach(a => Console.WriteLine(a.Nombre+" "+a.Apellidos));
        }
        // Close()
    }
}

// CambiarApellidosDeAutor(3);
// MostrarTodosLosAutores();
static void CambiarApellidosDeAutor(int autorId)
{
    using (var db = new Datos.SqliteDbContext())
    {
        var autor = db.Autores.Find(autorId);
        if (autor is not null)
        {
            autor.Apellidos = "Hernandez";
            db.SaveChanges();
        }
    }
}

EliminarUnAutor(3);
MostrarTodosLosAutores();
static void EliminarUnAutor(int autorId)
{
    using (var db = new Datos.SqliteDbContext())
    {
        var autor = db.Autores.Find(autorId);
        if (autor is not null)
        {
            db.Autores.Remove(autor);
            db.SaveChanges();
        }
    }
}

// var editorial1 = new Editorial
// {
//     Id = 1,
//     Nombre = "Editorial Uno"
// };

// var editorial2 = new Editorial
// {
//     Id = 2,
//     Nombre = "Editorial Dos"
// };

// // libro1 = autor1 y autor2, editorial1
// var libro1 = new Libro
// {
//     Id = 1,
//     Titulo = "Libro Uno",
//     EditorialId = editorial1.Id,
//     Editorial = editorial1,
//     Autores = new List<Autor>
//     {
//         autor1,
//         autor2
//     }
// };
// // libro2 = autor3, editorial2
// var libro2 = new Libro
// {
//     Id = 2,
//     Titulo = "Libro Dos",
//     EditorialId = editorial2.Id,
//     Editorial = editorial2,
//     Autores = new List<Autor> { autor3 }
// };

// // definir un cliente
// var cliente1 = new Cliente
// {
//     Id = 1,
//     Nombre = "Cliente",
//     Apellidos = "Uno",
//     Ine = "1234567890"
// };


// var prestamos = new List<Prestamo>();
// // realizar un prestamo
// var prestamo1 = new Prestamo
// {
//     Id = 1,
//     UsuarioId = usuario.Id,
//     Bibliotecario = usuario,
//     ClienteId = cliente1.Id,
//     Cliente = cliente1,
//     FechaDeSalida = DateTime.Now,
//     Libros = new List<Libro> { libro1, libro2 }
// };
// prestamos.Add(prestamo1);

// // imprimir el titulo de los libros que lleva prestados
// // el cliente1 en el prestamo1
// foreach (var libro in prestamo1.Libros)
// {
//     Console.WriteLine(libro.Titulo);
// }




// TODO: Convertir a SQL el modelo lógico