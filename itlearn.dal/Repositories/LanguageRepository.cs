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
    public class LanguageRepository
           : BaseRepository<Language>, ILanguageRepository
    {
        private readonly ApplicationContext _context;

        public LanguageRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Language>> GetAlll()
        {
            return await _context.Languages
                .Include(x => x.Chapters)
                .ToListAsync();
        }
    }
}
