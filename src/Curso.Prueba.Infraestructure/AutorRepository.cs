using Curso.Prueba.Domain;
using Microsoft.EntityFrameworkCore;

namespace Curso.Prueba.Infraestructure;

public class AutorRepository : EfRepository<Autor>, IAutorRepository
{
    public AutorRepository(CursoPruebaDbContext context) : base(context)
    {
    }

    public Task<bool> ExisteAutor(string nombre)
    {
        throw new NotImplementedException();
    }

    public Task<bool> ExisteAutor(string nombre, int idAutor)
    {
        throw new NotImplementedException();
    }
}
