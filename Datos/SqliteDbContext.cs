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
    public DbSet<Editorial> Editoriales { get; set; }
    public DbSet<Libro> Libros { get; set; }

    // definir la configuración de las tablas (relaciones)
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Relación de Libros a Editoriales (N:1)
        modelBuilder.Entity<Libro>()
            .HasOne(l => l.Editorial)
            .WithMany(e => e.Libros)
            .HasForeignKey(l => l.EditorialId);
            
        // Definir columna única
        modelBuilder.Entity<Libro>()
            .HasIndex(l => l.Isbn).IsUnique();

        base.OnModelCreating(modelBuilder);
    }

}
