using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class TestService : ITestService
    {
        private readonly IUnitOfWork _unitOfWork;

        public TestService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Count()
        {
            return await _unitOfWork.Tests
              .Count();
        }

        public async Task<bool> Create(TestVM model)
        {
            var theme = await _unitOfWork.Themes
                .GetByIdd(model.ThemeId);

            if (theme.Test != null)
                return false;

            return await _unitOfWork.Tests
                .Create(new Test()
                {
                    ThemeId = model.ThemeId,
                    Level = model.Level,
                    Description = model.Description,
                    IsCorrectTest = false
                });
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _unitOfWork.Tests
               .GetById(id);

            if (entity == null)
            {
                return false;
            }

            return await _unitOfWork.Tests
                .Delete(entity);
        }

        public async Task<List<TestVM>> GetAll()
        {
            var entities = await _unitOfWork.Tests
                .GetAlll();

            return entities.Select(x => new TestVM()
            {
                ThemeId = x.ThemeId,
                Level = x.Level,
                IsCorrectTest = x.IsCorrectTest,
                Description = x.Description,
                TestId = x.TestId,
                ThemeName = x.Theme.Name
            }).ToList();
        }

        public async Task<TestVM> GetById(int id)
        {
            var entity = await _unitOfWork.Tests
                    .GetById(id);

            if (entity == null)
            {
                return new TestVM();
            }

            return new TestVM()
            {
                TestId = entity.TestId,
                ThemeId = entity.ThemeId,
                IsCorrectTest = entity.IsCorrectTest,
                Description = entity.Description,
                Level = entity.Level
            };
        }


        public async Task<bool> IsCorrectTest(int testId)
        {
            var test = await _unitOfWork.Tests
                .GetByIdd(testId);

            var IsCorrectTest = test.Questions.Any(x => x.IsCorrectQuestion);

            if (!IsCorrectTest)
            {
                test.IsCorrectTest = false;
                await _unitOfWork.SaveChanges();

                return false;
            }

            test.IsCorrectTest = true;
            await _unitOfWork.SaveChanges();

            return true;
        }

        public async Task<bool> Update(TestVM model)
        {
            var entity = await _unitOfWork.Tests
                     .GetById(model.TestId);

            if (entity == null)
            {
                return false;
            }

            var isCorrectTest = await IsCorrectTest(model.TestId);

            entity.ThemeId = model.ThemeId;
            entity.Level = model.Level;
            entity.Description = model.Description;
            entity.IsCorrectTest = isCorrectTest;

            return await _unitOfWork.Tests
                .Update(entity);
        }
    }
}