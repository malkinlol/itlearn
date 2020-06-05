using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IAnswerRepository
          : IBaseRepository<Answer>
    {
        Task<List<Answer>> GetAlll();
        Task<Answer> GetByIdd(int answerId);
    }
}
