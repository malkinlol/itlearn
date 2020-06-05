using itlearn.dal.Entities;
using itlearn.model.ViewModels.Advice;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.bll.api.Interfaces
{
    public interface IAdviceService
    {
        List<AdviceVM> GetAll();
        AdviceVM GetById(int id);
        AdviceVM Create(AdviceVM model);
        void Delete(int id);
    }
}
