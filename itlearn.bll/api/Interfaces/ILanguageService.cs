using itlearn.model.ViewModels.Language;
using System.Collections.Generic;

namespace itlearn.bll.api.Interfaces
{
    public interface ILanguageService
    {
        List<LanguageVM> GetAll();
        LanguageVM GetById(int id);
        LanguageVM Create(LanguageVM model);
        void Delete(int id);
    }
}
