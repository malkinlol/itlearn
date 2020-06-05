using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface ICommentRepository
          : IBaseRepository<Comment>
    {
        Task<List<Comment>> GetByUser(string userName);
        Task<List<Comment>> GetByPost(int postId);
        Task<List<Comment>> GetAlll();
        Task<List<Comment>> GetIsConfirm();
        Task<List<Comment>> GetIsNotConfirm();
    }
}
