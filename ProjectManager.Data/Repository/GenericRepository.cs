using Microsoft.EntityFrameworkCore;
using ProjectManager.Data.Context;
using ProjectManager.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManager.Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly PMContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(PMContext context)
        {
            this._dbContext = context;
            this._dbSet = this._dbContext.Set<T>();
        }

        public async Task Add(T entity)
        {
            await this._dbSet.AddAsync(entity);
            await this._dbContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            this._dbSet.Remove(entity);
            this._dbContext.SaveChanges();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this._dbSet.ToListAsync();
        }

        public T GetbyId(int id)
        {
            return this._dbSet.Find(id);
        }

        public Task Update(T entity)
        {
            this._dbSet.Attach(entity);
            this._dbContext.Entry(entity).State = EntityState.Modified;
            return this._dbContext.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            throw new NotImplementedException();
        }
    }
}
