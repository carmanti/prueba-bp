using Curso.Prueba.Domain;
using Microsoft.EntityFrameworkCore;

namespace Curso.Prueba.Infraestructure;

public class EjercicioPruebaDbContext: DbContext, IUnitOfWork
{
    public EjercicioPruebaDbContext()
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;
        var path = Environment.GetFolderPath(folder);
        DbPath = Path.Join(path, "curso.prueba-biblioteca.db");
    }

    public DbSet<Autor> Autors {get; set;}
    public DbSet<Book> Libros {get; set;}

    public string DbPath {get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
                            => options.UseSqlite($"Data Source={DbPath}");
    
}
