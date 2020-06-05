using itlearn.model.ViewModels.Story;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.bll.api.Interfaces
{
    public interface IStoryService
    {
        List<StoryVM> GetAll();
        StoryVM GetById(int id);
        StoryVM Create(StoryVM model);
        void Delete(int id);
    }
}
