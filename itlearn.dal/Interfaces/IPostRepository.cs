using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IPostRepository
           : IBaseRepository<Post>
    {
        Task<List<Post>> GetAlll();
        Task<List<Post>> GetByUser(string userName);
        Task<Post> GetByIdd(int postId);
    }
}
