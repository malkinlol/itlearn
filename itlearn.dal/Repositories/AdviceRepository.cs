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
    public class AdviceRepository
            : BaseRepository<Advice>, IAdviceRepository
    {
        private readonly ApplicationContext _context;

        public AdviceRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Advice>> GetAlll()
        {
            return await _context.Advices
                .Include(x => x.User)
                .ToListAsync();
        }
    }
}
