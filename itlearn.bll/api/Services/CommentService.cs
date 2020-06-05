using itlearn.bll.api.Interfaces;
using itlearn.model.ViewModels.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itlearn.bll.api.Services
{
    public class CommentService : ICommentService
    {
        private readonly List<CommentVM> _comments;

        public CommentService()
        {
            _comments = new List<CommentVM>()
            {
                new CommentVM() { CommentId = 1, Message = "Message"},
                new CommentVM() { CommentId = 2, Message = "Message"},
                new CommentVM() { CommentId = 3, Message = "Message"},
                new CommentVM() { CommentId = 4, Message = "Message"}
            };
        }

        public CommentVM Create(CommentVM model)
        {
            model.Message = "Message";

            _comments.Add(model);
            return model;
        }

        public void Delete(int id)
        {
            var exsiting = _comments.FirstOrDefault(x => x.CommentId == id);
            _comments.Remove(exsiting);
        }

        public List<CommentVM> GetAll()
        {
            return _comments;
        }

        public CommentVM GetById(int id)
        {
            return _comments.FirstOrDefault(x => x.CommentId == id);
        }
    }
}
