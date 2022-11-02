
namespace Curso.Prueba.Domain;
    public interface IBookRepository: IRepository<Book>
    {
            Task<bool> ExisteLibro(string titulo);
    
    Task<bool> ExisteLibro(string titulo, int idLibro);
    }