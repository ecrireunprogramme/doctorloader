using System.Linq.Expressions;
using DoctorLoader.Domain;

namespace DoctorLoader.Application.Contracts.Interfaces.Repositories;

public interface IRepositoryBase<TEntity> where TEntity : BaseEntity
{
    void Add(TEntity entity);
    void Delete(TEntity entity);
    void Update(TEntity entity);
    IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> expression, 
        bool trackChanges = false);
    IQueryable<TEntity> FindAll(bool trackChanges = false);
}
