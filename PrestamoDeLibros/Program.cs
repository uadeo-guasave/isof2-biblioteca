// string nombre = txtNombre.text;
// var asigna tipo de dato por inferencia
// toma el tipo de dato al inicializarse
using Datos;
using Microsoft.EntityFrameworkCore;

// InicializarBaseDeDatos();
// GuardarAutores();

static void InicializarBaseDeDatos()
{
    var db = new Datos.SqliteDbContext();
    db.Database.EnsureDeleted();
    db.Database.EnsureCreated();
}

var usuario = new Usuario();
usuario.Alias = "user1";
usuario.Contraseña = "123456";
usuario.CorreoElectronico = "mi@correo.com";
usuario.Telefono = "6870000000";
usuario.Tipo = TipoDeUsuario.Administrador;



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

// MostrarTodosLosAutores(); 
static void MostrarTodosLosAutores()
{
    using (var db = new Datos.SqliteDbContext())
    {
        // Open()
        var autores = db.Autores.ToList();
        if (autores.Any())
        {
            autores.ForEach(a => Console.WriteLine(a.Nombre + " " + a.Apellidos));
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

// EliminarUnAutor(3);
// MostrarTodosLosAutores();
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

// CrearEditoriales();

static void CrearEditoriales()
{
    var editorial1 = new Editorial
    {
        Nombre = "Editorial Uno"
    };
    var editorial2 = new Editorial
    {
        Nombre = "Editorial Dos"
    };
    using (var db = new Datos.SqliteDbContext())
    {
        db.Editoriales.Add(editorial1);
        db.Editoriales.Add(editorial2);
        db.SaveChanges();
    }
}

// CrearLibros();

static void CrearLibros()
{
    // // libro1 = autor1 y autor2, editorial1
    var libro1 = new Libro
    {
        Titulo = "Libro Uno",
        Isbn = "123",
        EditorialId = 1
    };
    // // libro2 = autor3, editorial2
    var libro2 = new Libro
    {
        Titulo = "Libro Dos",
        Isbn = "456",
        EditorialId = 2
    };

    var libro3 = new Libro
    {
        Titulo = "Libro Tres",
        Isbn = "789",
        EditorialId = 1
    };
    using (var db = new Datos.SqliteDbContext())
    {
        db.Libros.Add(libro1);
        db.Libros.Add(libro2);
        db.Libros.Add(libro3);
        db.SaveChanges();
    }
}


MostrarLibrosYEditoriales();

static void MostrarLibrosYEditoriales()
{
    using (var db = new Datos.SqliteDbContext())
    {
        var libros = db.Libros.Include(l => l.Editorial).ToList();
        if (libros.Count > 0)
        {
            foreach (var libro in libros)
            {
                Console.WriteLine($"Id: {libro.Id}, Titulo: {libro.Titulo}, ISBN: {libro.Isbn}, Editorial: {libro.Editorial.Nombre}");
            }
        }
    }
}

MostrarLibrosDeLaEditorial(1);

static void MostrarLibrosDeLaEditorial(int editorialId)
{
    using (var db = new Datos.SqliteDbContext())
    {
        var libros = db.Libros.Include(l => l.Editorial).Where(l => l.EditorialId == editorialId).ToList();
        if (libros.Count > 0)
        {
            foreach (var libro in libros)
            {
                Console.WriteLine($"Id: {libro.Id}, Titulo: {libro.Titulo}, ISBN: {libro.Isbn}, Editorial: {libro.Editorial.Nombre}");
            }
        }
    }
}

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