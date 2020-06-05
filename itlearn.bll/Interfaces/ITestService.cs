using itlearn.model.ViewModels.Test;
using System;
using System.Threading.Tasks;

namespace itlearn.bll.Interfaces
{
    public interface ITestService : IBaseService<TestVM>
    {
        Task<bool> IsCorrectTest(int testId);
    }
}
