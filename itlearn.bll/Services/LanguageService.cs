using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Language;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class LanguageService : ILanguageService
    {
        private readonly IUnitOfWork _unitOfWork;

        public LanguageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Count()
        {
            return await _unitOfWork.Languages
              .Count();
        }

        public async Task<bool> Create(LanguageVM model)
        {
            return await _unitOfWork.Languages
               .Create(new Language()
               {
                   Name = model.Name,
                   Avatar = model.Avatar,
                   Description = model.Description,
                   IsEnable = false
               });
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _unitOfWork.Languages
               .GetById(id);

            if (entity == null)
            {
                return false;
            }

            return await _unitOfWork.Languages
                .Delete(entity);
        }

        public async Task<List<LanguageVM>> GetAll()
        {
            var entities = await _unitOfWork.Languages
                .GetAlll();

            return entities.Select(x => new LanguageVM()
            {
                LanguageId = x.LanguageId,
                Name = x.Name,
                IsEnable = x.IsEnable,
                Avatar = x.Avatar,
                Description = x.Description
            }).ToList();
        }

        public async Task<LanguageVM> GetById(int id)
        {
            var entity = await _unitOfWork.Languages
                    .GetById(id);

            if (entity == null)
            {
                return new LanguageVM();
            }

            return new LanguageVM()
            {
                LanguageId = entity.LanguageId,
                Avatar = entity.Avatar,
                Name = entity.Name,
                IsEnable = entity.IsEnable,
                Description = entity.Description
            };
        }

        public async Task<bool> Update(LanguageVM model)
        {
            var entity = await _unitOfWork.Languages
                     .GetById(model.LanguageId);

            if (entity == null)
            {
                return false;
            }

            entity.Name = model.Name;
            entity.Avatar = model.Avatar;
            entity.Description = model.Description;
            entity.IsEnable = model.IsEnable;

            return await _unitOfWork.Languages
                .Update(entity);
        }
    }
}
