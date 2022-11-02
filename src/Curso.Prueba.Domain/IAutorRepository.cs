public interface IAutorRepository
{
    Task<bool> ExisteAutor(string nombre);
    
    Task<bool> ExisteAutor(string nombre, int idAutor);
}