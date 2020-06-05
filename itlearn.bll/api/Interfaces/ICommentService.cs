using itlearn.model.ViewModels.Comment;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.bll.api.Interfaces
{
    public interface ICommentService
    {
        List<CommentVM> GetAll();
        CommentVM GetById(int id);
        CommentVM Create(CommentVM model);
        void Delete(int id);
    }
}
