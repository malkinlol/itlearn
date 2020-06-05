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
    public class TestRepository
          : BaseRepository<Test>, ITestRepository
    {
        private readonly ApplicationContext _context;

        public TestRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Test>> GetAlll()
        {
            return await _context.Tests
                .Include(x => x.Theme)
                .ToListAsync();
        }

        public async Task<Test> GetByIdd(int testId)
        {
            return await _context.Tests
                .Include(x => x.Questions)
                .Include(x => x.Theme)
                .FirstOrDefaultAsync(x => x.TestId == testId);
        }
    }
}
