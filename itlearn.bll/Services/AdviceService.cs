using itlearn.bll.Interfaces;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Advice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class AdviceService : IAdviceService
    {

        private readonly IUnitOfWork _unitOfWork;

        public AdviceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task<int> Count()
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(AdviceVM model)
        {
            return await _unitOfWork.Advices
                 .Create(new dal.Entities.Advice()
                 {
                     Link = model.Link,
                     Date = DateTime.Now,
                     TestId = model.TestId,
                     Status = model.Status,
                     UserId = model.UserId
                 });
        }

        public async Task<bool> Delete(int id)
        {
            var advice = await _unitOfWork.Advices
                .GetById(id);

            return await _unitOfWork.Advices
                .Delete(advice);
        }

        public async Task<List<AdviceVM>> GetAll()
        {
            var advices = await _unitOfWork.Advices
                .GetAlll();

            return advices
                .Select(x => new AdviceVM()
                {
                    UserId = x.UserId,
                    Date = x.Date,
                    Status = x.Status,
                    TestId = x.TestId,
                    AdviceId = x.AdviceId,
                    Link = x.Link
                }).ToList();
        }

        public async Task<AdviceVM> GetById(int id)
        {
            var advice = await _unitOfWork.Advices
               .GetById(id);

            return new AdviceVM()
            {
                AdviceId = advice.AdviceId,
                Status = advice.Status,
                TestId = advice.TestId,
                Link = advice.Link,
                Date = advice.Date,
                UserId = advice.UserId
            };
        }

        public Task<bool> Update(AdviceVM model)
        {
            throw new NotImplementedException();
        }
    }
}
