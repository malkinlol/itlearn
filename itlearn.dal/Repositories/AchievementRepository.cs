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
    public class AchievementRepository
              : BaseRepository<Achievement>, IAchievementRepository
    {
        private readonly ApplicationContext _context;

        public AchievementRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Achievement>> GetAlll()
        {
            return await _context.Achievements
                 .Include(x => x.User)
                 .ToListAsync();
        }
    }
}
