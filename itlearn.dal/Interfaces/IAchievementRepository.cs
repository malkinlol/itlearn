using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IAchievementRepository
        : IBaseRepository<Achievement>
    {
        public Task<List<Achievement>> GetAlll();
    }
}
