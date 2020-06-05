using itlearn.model.ViewModels.Question;
using System;
using System.Threading.Tasks;

namespace itlearn.bll.Interfaces
{
    public interface IQuestionService : IBaseService<QuestionVM>
    {
        Task<bool> IsCorrectQuestion(int guid);
    }
}
