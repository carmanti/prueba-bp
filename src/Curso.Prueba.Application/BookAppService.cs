using Curso.Prueba.Domain;

namespace Curso.Prueba.Application;

public class BookAppService : IBookAppService
{
    public Task<BookDto> CreateAsync(BookAppService libroDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int idLibro)
    {
        throw new NotImplementedException();
    }

    public ICollection<BookDto> GetAll()
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(int idLibro, BookAppService libroDto)
    {
        throw new NotImplementedException();
    }
}
