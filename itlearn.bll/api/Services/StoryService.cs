using itlearn.bll.api.Interfaces;
using itlearn.model.ViewModels.Story;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itlearn.bll.api.Services
{
    public class StoryService : IStoryService
    {
        private readonly List<StoryVM> _stories;

        public StoryService()
        {
            _stories = new List<StoryVM>()
            {
                new StoryVM() { StoryId = 1, Link = "Link"},
                new StoryVM() { StoryId = 2, Link = "Link"},
                new StoryVM() { StoryId = 3, Link = "Link"},
                new StoryVM() { StoryId = 4, Link = "Link"}
            };
        }

        public StoryVM Create(StoryVM model)
        {
            model.Link = "Link";

            _stories.Add(model);
            return model;
        }

        public void Delete(int id)
        {
            var exsiting = _stories.FirstOrDefault(x => x.StoryId == id);
            _stories.Remove(exsiting);
        }

        public List<StoryVM> GetAll()
        {
            return _stories;
        }

        public StoryVM GetById(int id)
        {
            return _stories.FirstOrDefault(x => x.StoryId == id);
        }
    }
}
