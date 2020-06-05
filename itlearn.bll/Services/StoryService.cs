using itlearn.bll.Interfaces;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class StoryService : IStoryServices
    {

        private readonly IUnitOfWork _unitOfWork;

        public StoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(StoryVM model)
        {
            return await _unitOfWork.Stories
                .Create(new dal.Entities.Story()
                {
                    Link = model.Link,
                    UserId = model.UserId,
                    ThemeId = model.ThemeId
                });
        }

        public async Task<bool> Delete(int id)
        {
            var story = await _unitOfWork.Stories
                .GetById(id);

            return await _unitOfWork.Stories.Delete(story);
        }

        public async Task<List<StoryVM>> GetAll()
        {
            var stories = await _unitOfWork.Stories
                .GetAlll();

            return stories
                .Select(x => new StoryVM()
                {
                    UserId = x.UserId,
                    Link = x.Link,
                    ThemeId = x.ThemeId,
                    StoryId = x.StoryId
                }).ToList();
        }

        public async Task<StoryVM> GetById(int id)
        {
            var story = await _unitOfWork.Stories
               .GetById(id);

            return new StoryVM()
            {
                Link = story.Link,
                StoryId = story.StoryId,
                UserId = story.UserId,
                ThemeId = story.ThemeId
            };
        }

        public Task<bool> Update(StoryVM model)
        {
            throw new NotImplementedException();
        }
    }
}
