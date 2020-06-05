using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IUnitOfWork
    {
        ILanguageRepository Languages { get; }
        IChapterRepository Chapters { get; }
        IThemeRepository Themes { get; }
        ITestRepository Tests { get; }
        IQuestionRepository Questions { get; }
        IAnswerRepository Answers { get; }
        INotificationRepository Notifications { get; }
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }
        IAchievementRepository Achievements { get; }
        IAdviceRepository Advices { get; }
        IStoryRepository Stories { get; }
        Task<int> SaveChanges();
    }
}
