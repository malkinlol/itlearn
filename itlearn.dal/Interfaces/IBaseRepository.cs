using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> Create(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
        Task<int> Count();
    }
}
