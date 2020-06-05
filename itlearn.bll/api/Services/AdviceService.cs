using itlearn.bll.api.Interfaces;
using itlearn.model.ViewModels.Advice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace itlearn.bll.api.Services
{
    public class AdviceService : IAdviceService
    {
        private readonly List<AdviceVM> _advices;

        public AdviceService()
        {
            _advices = new List<AdviceVM>()
            {
                new AdviceVM() {AdviceId = 1, Status = "Status"},
                new AdviceVM() {AdviceId = 2, Status = "Status"},
                new AdviceVM() {AdviceId = 3, Status = "Status"},
                new AdviceVM() {AdviceId = 4, Status = "Status"}
            };
        }

        public AdviceVM Create(AdviceVM model)
        {
            model.Status = "Status";

            _advices.Add(model);
            return model;
        }

        public void Delete(int id)
        {
            var exsiting = _advices.FirstOrDefault(x => x.AdviceId == id);
            _advices.Remove(exsiting);
        }

        public List<AdviceVM> GetAll()
        {
            return _advices;
        }

        public AdviceVM GetById(int id)
        {
            return _advices.FirstOrDefault(x => x.AdviceId == id);
        }
    }
}
