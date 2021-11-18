using CompanyEmployee.Entities;
using CompanyEmployee.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEmployee.Repository.Implementation
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly RepositoryContext _repositoryContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(RepositoryContext repositoryContext) 
        {
            _repositoryContext = repositoryContext;
            _dbSet = _repositoryContext.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void AddRange(IList<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public async Task AddRangeAsync(IList<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(IList<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate);
        }

        public TEntity Get(int id)
        {
            return _dbSet.Find(id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<TEntity> GetAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
