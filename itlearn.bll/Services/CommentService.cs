using itlearn.bll.Interfaces;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Comment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class CommentService : ICommentService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CommentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public int CountByPost(int postId)
        {
            var count = _unitOfWork
                .Comments.GetByPost(postId)
                .GetAwaiter().GetResult()
                .Where(x => x.IsConfirm)
                .Count();

            return count;
        }

        public async Task<bool> Create(CommentVM model)
        {
            return await _unitOfWork.Comments
                .Create(new dal.Entities.Comment
                {
                    CommentDate = DateTime.Now,
                    Message = model.Message,
                    PostId = model.PostId,
                    UserId = model.UserId
                });
        }

        public async Task<bool> Delete(int id)
        {
            var comment = await _unitOfWork.Comments
                .GetById(id);

            if (comment == null)
                return false;

            return await _unitOfWork.Comments
                .Delete(comment);
        }

        public async Task<List<CommentVM>> GetAll()
        {
            var posts = await _unitOfWork.Comments
               .GetAlll();

            return posts.Select(x => new CommentVM()
            {
                CommentId = x.CommentId,
                Avatar = x.User.Avatar,
                CommentDate = x.CommentDate,
                IsConfirm = x.IsConfirm,
                Message = x.Message,
                PostId = x.PostId,
                PostName = x.Post.Title,
                UserId = x.UserId,
                UserName = x.User.UserName
            }).ToList();
        }

        public async Task<CommentVM> GetById(int id)
        {
            var comment = await _unitOfWork.Comments
               .GetById(id);

            if (comment == null)
                return null;

            return new CommentVM()
            {
                CommentId = comment.CommentId,
                PostId = comment.PostId
            };
        }

        public async Task<List<CommentVM>> GetByPost(int postId)
        {
            var posts = await _unitOfWork.Comments
                .GetByPost(postId);

            return posts.Select(x => new CommentVM()
            {
                CommentId = x.CommentId,
                Avatar = x.User.Avatar,
                CommentDate = x.CommentDate,
                IsConfirm = x.IsConfirm,
                Message = x.Message,
                PostId = x.PostId,
                PostName = x.Post.Title,
                UserId = x.UserId,
                UserName = x.User.UserName
            }).ToList();
        }

        public async Task<List<CommentVM>> GetByUser(string userName)
        {
            var posts = await _unitOfWork.Comments
                .GetByUser(userName);

            return posts.Select(x => new CommentVM()
            {
                CommentId = x.CommentId,
                Avatar = x.User.Avatar,
                CommentDate = x.CommentDate,
                IsConfirm = x.IsConfirm,
                Message = x.Message,
                PostName = x.Post.Title,
                PostId = x.PostId,
                UserId = x.UserId,
                UserName = x.User.UserName
            }).ToList();
        }    

        public async Task<bool> Update(CommentVM model)
        {
            throw new NotImplementedException();
        }
    }
}
