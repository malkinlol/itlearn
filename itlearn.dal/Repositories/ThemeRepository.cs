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
    public class ThemeRepository
         : BaseRepository<Theme>, IThemeRepository
    {
        private readonly ApplicationContext _context;
        public ThemeRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Theme>> GetAlll()
        {
            return await _context.Themes
                .Include(x => x.Chapter)
                .ToListAsync();
        }

        public async Task<Theme> GetByIdd(int themeId)
        {
            return await _context.Themes
                .Include(x => x.Test)
                .Include(x => x.Chapter)
                .FirstOrDefaultAsync(x => x.ThemeId == themeId);
        }
    }
}
