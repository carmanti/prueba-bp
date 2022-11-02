
using Curso.Prueba.Domain;
using Microsoft.EntityFrameworkCore;
namespace Curso.Prueba.Infraestructure;

public class BookRepository : EfRepository<Book>, IBookRepository
{
    
    public BookRepository(CursoPruebaDbContext context) : base(context)
    {
    }

    public Task<bool> ExisteLibro(string titulo)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExisteLibro(string titulo, int idLibro)
    {
        throw new NotImplementedException();
    }
}
