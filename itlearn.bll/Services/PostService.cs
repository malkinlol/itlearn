using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Post;
using itlearn.model.ViewModels.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class PostService : IPostService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(PostVM model)
        {
            var tags = string.Empty;

            if (model.Tags != null)
                tags = ConvertStringArrayToString(model.Tags);

            return await _unitOfWork.Posts
                .Create(new Post
                {
                    Message = model.Message,
                    MiniDescription = model.MiniDescription,
                    Tags = tags,
                    Title = model.Title,
                    PostDate = DateTime.Now,
                    CountWatch = 0,
                    UserId = model.UserId
                });
        }

        private string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }

        public async Task<bool> Delete(int id)
        {
            var post = await _unitOfWork.Posts
                .GetById(id);

            if (post == null)
                return false;

            return await _unitOfWork.Posts.Delete(post);
        }

        public async Task<List<PostVM>> GetByTag(string tag)
        {
            var posts = await _unitOfWork.Posts
                .GetAlll();

            if (string.IsNullOrEmpty(tag))
            {
                return posts.Select(x => new PostVM
                {
                    PostId = x.PostId,
                    MiniDescription = x.MiniDescription,
                    Message = x.Message,
                    Tags = ConvertStringToStringArray(x?.Tags),
                    Title = x.Title,
                    PostDate = x.PostDate,
                    CountWatch = x.CountWatch,
                    UserId = x.UserId,
                    Avatar = x.User.Avatar,
                    UserName = x.User.UserName
                }).ToList();
            }

            return posts.Select(x => new PostVM
            {
                PostId = x.PostId,
                Message = x.Message,
                Tags = ConvertStringToStringArray(x.Tags),
                Title = x.Title,
                PostDate = x.PostDate,
                MiniDescription = x.MiniDescription,
                CountWatch = x.CountWatch,
                UserId = x.UserId,
                UserName = x.User.UserName,
                Avatar = x.User.Avatar

            })
                .Where(x => x.Tags.Contains(tag))
                .ToList();
        }

        public async Task<PostVM> GetById(int id)
        {
            var post = await _unitOfWork.Posts
                .GetByIdd(id);

            if (post == null)
                return null;

            return new PostVM()
            {
                PostId = post.PostId,
                Message = post.Message,
                MiniDescription = post.MiniDescription,
                Tags = ConvertStringToStringArray(post.Tags),
                Title = post.Title,
                CountWatch = post.CountWatch,
                PostDate = post.PostDate,
                UserId = post.UserId,
                Avatar = post.User.Avatar,
                UserName = post.User.UserName
            };
        }

        private string[] ConvertStringToStringArray(string tags)
        {
            string[] tagsArray = tags.Split(new char[] { '.', ',', ' ' });
            return tagsArray;
        }

        public Task<List<PostVM>> GetTemp(int pageSize, int pageCurrent)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(PostVM model)
        {
            var post = await _unitOfWork.Posts.GetById(model.PostId);

            if (post == null)
                return false;

            post.Title = model.Title;
            post.Message = model.Message;

            if (post.CountWatch == model.CountWatch)
            {
                post.PostDate = DateTime.Now;
            }

            post.CountWatch = model.CountWatch;

            return await _unitOfWork.Posts.Update(post);
        }

        public async Task<List<PostVM>> GetAll()
        {
            var posts = await _unitOfWork.Posts
                 .GetAlll();

            return posts.Select(x => new PostVM
            {
                PostId = x.PostId,
                MiniDescription = x.MiniDescription,
                Message = x.Message,
                Tags = ConvertStringToStringArray(x?.Tags),
                Title = x.Title,
                PostDate = x.PostDate,
                CountWatch = x.CountWatch,
                UserId = x.UserId,
                Avatar = x.User.Avatar,
                UserName = x.User.UserName
            }).ToList();
        }

        public async Task<List<PostVM>> GetByUser(string userName)
        {
            var posts = await _unitOfWork.Posts
                .GetByUser(userName);

            return posts.Select(x => new PostVM
            {
                PostId = x.PostId,
                Message = x.Message,
                Tags = ConvertStringToStringArray(x.Tags),
                Title = x.Title,
                CountWatch = x.CountWatch,
                UserId = x.UserId,
                PostDate = x.PostDate,
                UserName = x.User.UserName
            }).ToList();
        }

        public async Task<List<PostVM>> GetBySearch(PostSearchVM model)
        {
            var filterPost = await GetByTag(model.Tag);

            if (!string.IsNullOrEmpty(model.Title))
                filterPost = filterPost.Where(x => x.Title.Contains(model.Title)).ToList();

            switch (model.Filter)
            {
                case "Все":
                    break;
                case "Новые":
                    filterPost = filterPost
                        .OrderByDescending(x => x.PostDate)
                        .ToList();
                    break;
                case "Популярные":
                    filterPost = filterPost
                         .OrderByDescending(x => x.CountWatch)
                         .ToList();
                    break;
                default:
                    break;
            }

            return filterPost
                .ToList();
        }
    }
}
