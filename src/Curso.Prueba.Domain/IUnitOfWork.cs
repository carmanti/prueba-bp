namespace Curso.Prueba.Domain;
public interface IUnitOfWork
{
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));

}