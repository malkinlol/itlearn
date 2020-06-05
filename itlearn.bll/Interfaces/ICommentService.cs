using itlearn.model.ViewModels.Comment;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace itlearn.bll.Interfaces
{
    public interface ICommentService
        : IBaseService<CommentVM>
    {
        int CountByPost(int postId);
        Task<List<CommentVM>> GetByUser(string userName);
        Task<List<CommentVM>> GetByPost(int postId);
    }
}
