using DoctorLoader.Application.Contracts.Interfaces.Repositories;
using DoctorLoader.Domain;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DoctorLoader.Infrastructure.Repositories
{
    internal class RepositoryBase<TEntity>(ApplicationDbContext dbContext) 
        : IRepositoryBase<TEntity> where TEntity : BaseEntity
    {
        private readonly ApplicationDbContext _dbContext = dbContext;

        public void Add(TEntity entity) 
            => _dbContext.Set<TEntity>().Add(entity);

        public void Delete(TEntity entity) 
            => _dbContext.Set<TEntity>().Remove(entity);

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression, bool trackChanges = false)
            => trackChanges 
                ? _dbContext.Set<TEntity>().Where(expression)
                : _dbContext.Set<TEntity>().Where(expression).AsNoTracking();

        public IQueryable<TEntity> FindAll(bool trackChanges = false)
            => trackChanges 
                ? _dbContext.Set<TEntity>()
                : _dbContext.Set<TEntity>().AsNoTracking();

        public void Update(TEntity entity)
            => _dbContext.Set<TEntity>().Update(entity);
    }
}
