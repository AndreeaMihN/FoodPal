using FoodPal.Providers.DomainModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FoodPal.Providers.DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly ProvidersContext _providersContext;
        protected readonly CatalogueItemsContext _catalogueItemsContext;
        protected readonly DbContext _dbContext;
        private readonly DbSet<T> _entities;

        public Repository(DbContext dbContext)
        {
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
            _entities = dbContext.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            // await _providersContext.Set<T>().AddAsync(entity);
            await _entities.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async Task<T> GetAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public void Remove(T entity)
        {
            _entities.Remove(entity);
        }

        public async Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> expression)
        {
            return await _entities.SingleOrDefaultAsync(expression);
        }
    }
}
