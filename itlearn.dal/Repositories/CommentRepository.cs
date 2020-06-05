using itlearn.dal.Context;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Repositories
{
    public class CommentRepository : BaseRepository<Comment>, ICommentRepository
    {
        private readonly ApplicationContext _context;

        public CommentRepository(ApplicationContext context)
        : base(context)
        {
            _context = context;
        }

        public async Task<List<Comment>> GetAlll()
        {
            return await _context.Comments
                .Include(x => x.Post)
                .Include(x => x.User)
                .OrderByDescending(x => x.CommentDate)
                .ToListAsync();
        }

        public async Task<List<Comment>> GetByPost(int postId)
        {
            return await _context.Comments
                 .Include(x => x.Post)
                 .Include(x => x.User)
                 .OrderByDescending(x => x.CommentDate)
                 .Where(x => x.PostId == postId)
                 .ToListAsync();
        }

        public async Task<List<Comment>> GetByUser(string userName)
        {
            return await _context.Comments
                 .Include(x => x.Post)
                 .Include(x => x.User)
                 .OrderByDescending(x => x.CommentDate)
                 .Where(x => x.User.UserName == userName)
                 .ToListAsync();
        }

        public async Task<List<Comment>> GetIsConfirm()
        {
            return await _context.Comments
                .Include(x => x.Post)
                .Include(x => x.User)
                .OrderByDescending(x => x.CommentDate)
                .Where(x => x.IsConfirm)
                .ToListAsync();
        }

        public async Task<List<Comment>> GetIsNotConfirm()
        {
            return await _context.Comments
              .Include(x => x.Post)
              .Include(x => x.User)
              .OrderByDescending(x => x.CommentDate)
              .Where(x => !x.IsConfirm)
              .ToListAsync();
        }
    }
}
