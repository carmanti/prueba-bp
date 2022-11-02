namespace Curso.Prueba.Application
{
    public interface IBookAppService
    {
        ICollection<BookDto> GetAll();
        Task<BookDto> CreateAsync(BookAppService libroDto);
        Task UpdateAsync (int idLibro, BookAppService libroDto);
        Task<bool> DeleteAsync (int idLibro);
    }
}