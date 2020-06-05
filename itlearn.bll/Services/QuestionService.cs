using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IUnitOfWork _unitOfWork;

        public QuestionService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Count()
        {
            return await _unitOfWork.Questions
              .Count();
        }

        public async Task<bool> Create(QuestionVM model)
        {
            //var entities = await _unitOfWork.Questions
            //    .GetAlll();

            var test = await _unitOfWork.Tests
                .GetByIdd(model.TestId);

            var exists = test.Questions.Any(x => x.SomeQuestion == model.SomeQuestion);

            //var exists = entities
            // .Where(x => x.SomeQuestion == model.SomeQuestion && x.Test.TestId == model.TestId)
            // .FirstOrDefault();

            if (exists)
                return false;

            return await _unitOfWork.Questions
                   .Create(new Question()
                   {
                       SomeQuestion = model.SomeQuestion,
                       Avatar = model.Avatar,
                       TestId = model.TestId,
                       IsCorrectQuestion = false
                   });
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _unitOfWork.Questions
               .GetById(id);

            if (entity == null)
            {
                return false;
            }

            return await _unitOfWork.Questions
                .Delete(entity);
        }

        public async Task<List<QuestionVM>> GetAll()
        {
            var entities = await _unitOfWork.Questions
                .GetAlll();

            return entities.Select(x => new QuestionVM()
            {
                QuestionId = x.QuestionId,
                TestId = x.TestId,
                Avatar = x.Avatar,
                SomeQuestion = x.SomeQuestion,
                ThemeName = x.Test?.Theme?.Name
            }).ToList();
        }

        public async Task<QuestionVM> GetById(int id)
        {
            var entity = await _unitOfWork.Questions
                    .GetById(id);

            if (entity == null)
            {
                return new QuestionVM();
            }

            return new QuestionVM()
            {
                QuestionId = entity.QuestionId,
                Avatar = entity.Avatar,
                TestId = entity.TestId,
                SomeQuestion = entity.SomeQuestion
            };
        }


        public async Task<bool> IsCorrectQuestion(int questionId)
        {
            var question = await _unitOfWork.Questions
                .GetByIdd(questionId);

            var isRightAnswer = question.Answers.Any(x => x.IsRight);
            var IsNotRightAnswer = question.Answers.Any(x => !x.IsRight);
            var countRightAnswer = question.Answers.Count(x => x.IsRight);

            if ((isRightAnswer && IsNotRightAnswer) || (isRightAnswer))
            {
                question.IsCorrectQuestion = true;
                await _unitOfWork.SaveChanges();

                return true;
            }

            question.IsCorrectQuestion = false;
            await _unitOfWork.SaveChanges();

            return false;
        }

        public async Task<bool> Update(QuestionVM model)
        {
            var entities = await _unitOfWork.Questions
                 .GetAlll();

            var exists = entities
                 .Where(x => x.SomeQuestion == model.SomeQuestion && x.Test.TestId == model.TestId)
                 .FirstOrDefault();

            if (exists != null)
                return false;

            var entity = await _unitOfWork.Questions
                     .GetByIdd(model.QuestionId);

            if (entity == null)
            {
                return false;
            }

            var isCorrectQuestion = await IsCorrectQuestion(model.QuestionId);

            entity.SomeQuestion = model.SomeQuestion;
            if (!string.IsNullOrEmpty(model.Avatar))
            {
                entity.Avatar = model.Avatar;
            }
            entity.TestId = model.TestId;
            entity.IsCorrectQuestion = isCorrectQuestion;

            return await _unitOfWork.Questions
                .Update(entity);
        }
    }
}