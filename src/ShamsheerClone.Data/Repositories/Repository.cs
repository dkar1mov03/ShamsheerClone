using Microsoft.EntityFrameworkCore;
using ShamsheerClone.Data.DbContexts;
using ShamsheerClone.Data.IRepositories;
using ShamsheerClone.Domain.Commons;

namespace ShamsheerClone.Data.Repositories;

public class Repository<TEntity> : IRepository<TEntity> where TEntity : Auditable
{
    ShamsheerCloneDbContext _dbContext;
    DbSet<TEntity> _dbSet;
    public Repository(ShamsheerCloneDbContext dbContext)
    {
        _dbContext = dbContext;
        _dbSet = _dbContext.Set<TEntity>();
    }
    public async Task<bool> DeleteAsync(long id)
    {
        var entity = await _dbSet.FirstOrDefaultAsync(x => x.Id == id);
        _dbSet.Remove(entity);
        return await _dbContext.SaveChangesAsync() > 0;
    }

    public async Task<TEntity> InsertAsync(TEntity entity)
    {
        var enitity = await _dbSet.AddAsync(entity);

        await _dbContext.SaveChangesAsync();

        return enitity.Entity;
    }


    public IQueryable<TEntity> SelectAll() => _dbSet;

    public async Task<TEntity> SelectByIdAsync(long id) =>
        await _dbSet.FirstOrDefaultAsync(e => e.Id == id);

    public async Task<TEntity> UpdateAsync(TEntity entity)
    {
        var entit = _dbContext.Update(entity);
        await _dbContext.SaveChangesAsync();

        return entit.Entity;
    }
}
