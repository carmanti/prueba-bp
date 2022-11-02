using Curso.Prueba.Application;

public interface IAutorAppService
{
    ICollection<AutorDto> GetAll();
    Task<AutorDto> CreateAsync(AutorCRUDDto autorDto);
    Task UpdateAsync (int idAutor, AutorCRUDDto autorDto);
    Task<bool> DeleteAsync (int idAutor);
}