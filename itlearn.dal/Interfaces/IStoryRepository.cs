using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IStoryRepository
       : IBaseRepository<Story>
    {
        public Task<List<Story>> GetAlll();

    }
}
