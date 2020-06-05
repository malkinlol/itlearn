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
    public class AnswerRepository
             : BaseRepository<Answer>, IAnswerRepository
    {
        private readonly ApplicationContext _context;

        public AnswerRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Answer>> GetAlll()
        {
            return await _context.Answers
                 .Include(x => x.Question)
                 .ToListAsync();
        }

        public async Task<Answer> GetByIdd(int answerId)
        {
            return await _context.Answers
                .Include(x => x.Question)
                .FirstOrDefaultAsync(x => x.AnswerId == answerId);
        }
    }
}
