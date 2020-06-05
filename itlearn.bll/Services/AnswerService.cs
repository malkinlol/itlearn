using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels;
using itlearn.model.ViewModels.Answer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class AnswerService : IAnswerService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IQuestionService _questionService;
        private readonly ITestService _testService;

        public AnswerService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Count()
        {
            return await _unitOfWork.Answers.Count();
        }

        public async Task<bool> Create(AnswerVM model)
        {
            var question = await _unitOfWork.Questions
                .GetByIdd(model.QuestionId);

            var isExists = question.Answers.Any(x => x.SomeAnswer == model.SomeAnswer);

            if (isExists)
                return false;

            return await _unitOfWork.Answers
                .Create(new Answer
                {
                    IsRight = model.IsRight,
                    QuestionId = model.QuestionId,
                    SomeAnswer = model.SomeAnswer
                });
        }

        public async Task<bool> Delete(int id)
        {
            var answer = await _unitOfWork.Answers
                .GetById(id);

            if (answer == null)
                return false;

            //var question = await _questionService.GetById(answer.AnswerId);
            //var test = await _testService.GetById(question.TestId);

            var result = await _unitOfWork.Answers
                .Delete(answer);

            //await _questionService.IsCorrectQuestion(question.QuestionId);
            //await _testService.IsCorrectTest(test.TestId);

            return result;
        }

        public async Task<List<AnswerVM>> GetAll()
        {
            var answers = await _unitOfWork.Answers.GetAlll();

            return answers.Select(x => new AnswerVM()
            {
                AnswerId = x.AnswerId,
                IsRight = x.IsRight,
                QuestionId = x.QuestionId,
                QuestionName = x.Question?.SomeQuestion,
                SomeAnswer = x.SomeAnswer,
            }).ToList();
        }

        public async Task<AnswerVM> GetById(int id)
        {
            var answer = await _unitOfWork.Answers
                .GetByIdd(id);

            if (answer == null)
                return null;

            return new AnswerVM()
            {
                AnswerId = answer.AnswerId,
                ChapterName = answer.Question.Test?.Theme.Chapter.Name,
                LanguageName = answer.Question.Test?.Theme.Chapter.Language.Name,
                IsRight = answer.IsRight,
                QuestionId = answer.QuestionId,
                QuestionName = answer.Question.SomeQuestion,
                SomeAnswer = answer.SomeAnswer,
                ThemeName = answer.Question.Test?.Theme.Name
            };
        }


        public async Task<bool> Update(AnswerVM model)
        {
            var answer = await _unitOfWork.Answers
                .GetById(model.AnswerId);

            if (answer == null)
                return false;

            answer.IsRight = model.IsRight;
            answer.SomeAnswer = model.SomeAnswer;
            answer.QuestionId = model.QuestionId;

            return await _unitOfWork.Answers
                .Update(answer);
        }
    }
}
