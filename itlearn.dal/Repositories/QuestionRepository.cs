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
    public class QuestionRepository
           : BaseRepository<Question>, IQuestionRepository
    {
        private readonly ApplicationContext _context;

        public QuestionRepository(ApplicationContext context)
            : base(context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetAlll()
        {
            return await _context.Questions
                 .Include(x => x.Answers)
                 .Include(x => x.Test)
                 .ToListAsync();
        }

        public async Task<Question> GetByIdd(int questionId)
        {
            return await _context.Questions
                .Include(x => x.Test)
                .Include(x => x.Answers)
                .FirstOrDefaultAsync(x => x.QuestionId == questionId);
        }
    }
}
