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
    public class PostRepository
         : BaseRepository<Post>, IPostRepository
    {
        private readonly ApplicationContext _context;

        public PostRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Post>> GetAlll()
        {
            return await _context.Posts
                 .Include(x => x.User)
                 .ToListAsync();
        }

        public async Task<Post> GetByIdd(int postId)
        {
            return await _context.Posts
                .Include(x => x.User)
                .FirstOrDefaultAsync(x => x.PostId == postId);
        }

        public async Task<List<Post>> GetByUser(string userName)
        {
            return await _context.Posts
                 .Include(x => x.User)
                 .Where(x => x.User.UserName == userName)
                 .ToListAsync();
        }
    }
}
