using itlearn.bll.Interfaces;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Achievement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class AchievementService : IAchievementService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AchievementService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(AchievementVM model)
        {
            return await _unitOfWork.Achievements
                .Create(new dal.Entities.Achievement()
                {
                    Date = DateTime.Now,
                    TestId = model.TestId,
                    Persent = model.Persent,
                    Link = model.Link,
                    UserId = model.UserId
                });
        }

        public async Task<bool> Delete(int id)
        {
            var achive = await _unitOfWork.Achievements
                .GetById(id);

            return await _unitOfWork.Achievements.Delete(achive);
        }

        public async Task<List<AchievementVM>> GetAll()
        {
            var achievements = await _unitOfWork.Achievements
                .GetAlll();

            return achievements
                .Select(x => new AchievementVM()
                {
                    AchievementId = x.AchievementId,
                    Persent = x.Persent,
                    TestId = x.TestId,
                    Date = x.Date,
                    Link = x.Link,
                    UserId = x.UserId
                }).ToList();


        }

        public async Task<AchievementVM> GetById(int id)
        {
            var achive = await _unitOfWork.Achievements
                .GetById(id);

            return new AchievementVM()
            {
                UserId = achive.UserId,
                Link = achive.Link,
                Date = achive.Date,
                TestId = achive.TestId,
                Persent = achive.Persent,
                AchievementId = achive.AchievementId,
            };
        }

        public Task<bool> Update(AchievementVM model)
        {
            throw new NotImplementedException();
        }
    }
}
