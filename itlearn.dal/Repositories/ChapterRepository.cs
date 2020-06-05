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
    public class ChapterRepository
          : BaseRepository<Chapter>, IChapterRepository
    {
        private readonly ApplicationContext _context;
        public ChapterRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Chapter>> GetAlll()
        {
            return await _context.Chapters
                .Include(x => x.Language)
                .Include(x => x.Themes)
                .ToListAsync();
        }

        public async Task<Chapter> GetByIdd(int chapterId)
        {
            return await _context.Chapters
                .Include(x => x.Themes)
                .FirstOrDefaultAsync(x => x.ChapterId == chapterId);
        }
    }
}
