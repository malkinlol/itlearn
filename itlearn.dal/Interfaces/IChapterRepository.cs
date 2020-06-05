using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IChapterRepository
   : IBaseRepository<Chapter>
    {
        Task<List<Chapter>> GetAlll();
        Task<Chapter> GetByIdd(int chapterId);
    }
}
