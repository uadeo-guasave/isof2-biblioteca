using System;
using Microsoft.EntityFrameworkCore;

namespace Datos;

public class SqliteDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Db/biblioteca.sqlite");
        base.OnConfiguring(optionsBuilder);
    }

    // agregar los DbSet (cada DbSet corresponde a una tabla)
    public DbSet<Autor> Autores { get; set; }

    // definir la configuración de las tablas (relaciones)
}
