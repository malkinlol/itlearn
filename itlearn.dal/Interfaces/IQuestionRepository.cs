using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IQuestionRepository
        : IBaseRepository<Question>
    {
        Task<List<Question>> GetAlll();
        Task<Question> GetByIdd(int questionId);
    }
}
