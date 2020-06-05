using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface ITestRepository
         : IBaseRepository<Test>
    {
        Task<List<Test>> GetAlll();
        Task<Test> GetByIdd(int testId);
    }
}
