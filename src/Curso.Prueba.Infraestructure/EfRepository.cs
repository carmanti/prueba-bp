
using System.Linq.Expressions;
using Curso.Prueba.Domain;
using Microsoft.EntityFrameworkCore;

namespace Curso.Prueba.Infraestructure;

public abstract class EfRepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    public IUnitOfWork UnitOfWork => _context;
    protected readonly CursoPruebaDbContext _context;

    protected EfRepository(CursoPruebaDbContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        return entity;
    }

    public virtual void Delete(TEntity entity)
    {
        _context.Set<TEntity>().Remove(entity);
    }

    public IQueryable<TEntity> GetAll(bool asNoTracking = true)
    {
        if(asNoTracking)
            return _context.Set<TEntity>().AsNoTracking();
        else
            return _context.Set<TEntity>().AsQueryable();
    }

    public IQueryable<TEntity> GetAllIncluding(params Expression<Func<TEntity, object>>[] includeProperties)
    {
        IQueryable<TEntity> queryable = GetAll();
        
        foreach (Expression<Func<TEntity, object>> includeProperty in includeProperties)
        {
            queryable = queryable.Include<TEntity, object>(includeProperty);
        }

        return queryable;
    }

    public virtual async Task<TEntity> GetByIdAsync(int id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public virtual async Task UpdateAsync(TEntity entity)
    {
        _context.Update(entity);
        return;
    }
}
