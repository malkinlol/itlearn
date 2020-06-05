using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itlearn.bll.Interfaces
{
    public interface IBaseService<T>
          where T : class
    {
        Task<List<T>> GetAll();
        Task<T> GetById(int id);
        Task<bool> Create(T model);
        Task<bool> Update(T model);
        Task<bool> Delete(int id);
        Task<int> Count();
    }
}
