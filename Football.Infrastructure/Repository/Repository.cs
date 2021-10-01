using Football.Domain.Repository;
using Football.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Football.Infrastructure.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly FootballDbContext _dbContext;
        DbSet<TEntity> _dbSet;
        public Repository(FootballDbContext footballDbContext)
        {
            _dbContext = footballDbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }
        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            _dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            
            _dbSet.Update(entity);
            _dbContext.SaveChanges();
        }

        /*public List<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }*/
        
        public List<TEntity> GetAll()
        {
            return _dbSet.Where(_ => true).ToList();
        }
    }
}
