using itlearn.dal.Context;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Repositories
{
   public class StoryRepository
            : BaseRepository<Story>, IStoryRepository
    {
        private readonly ApplicationContext _context;

        public StoryRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Story>> GetAlll()
        {
            return await _context.Stories
                .Include(x => x.User)
                .ToListAsync();
        }
    }
}
