using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManager.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        T GetbyId(int id);
        Task Add(T entity);
        Task Update(T entity);
        void Delete(T entity);
        bool Exists(int Id);
    }
}
