using itlearn.bll.api.Interfaces;
using itlearn.model.ViewModels.Language;
using System.Collections.Generic;
using System.Linq;

namespace itlearn.bll.api.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly List<LanguageVM> _languages;

        public LanguageService()
        {
            _languages = new List<LanguageVM>()
            {
                new LanguageVM() { LanguageId = 1, Name = "Name", Description = "Description" },
                new LanguageVM() { LanguageId = 2, Name = "Name", Description = "Description" },
                new LanguageVM() { LanguageId = 3, Name = "Name", Description = "Description" },
                new LanguageVM() { LanguageId = 4, Name = "Name", Description = "Description" }
            };
        }

        public LanguageVM Create(LanguageVM language)
        {
            language.Name = "Name";
            language.Description = "Description";

            _languages.Add(language);
            return language;
        }

        public void Delete(int id)
        {
            var exsiting = _languages.FirstOrDefault(x => x.LanguageId == id);
            _languages.Remove(exsiting);
        }

        public List<LanguageVM> GetAll()
        {
            return _languages;
        }

        public LanguageVM GetById(int id)
        {
            return _languages.FirstOrDefault(x => x.LanguageId == id);
        }
    }
}
