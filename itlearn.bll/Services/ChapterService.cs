using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Chapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class ChapterService : IChapterService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChapterService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Count()
        {
            return await _unitOfWork.Chapters
              .Count();
        }

        public async Task<bool> Create(ChapterVM model)
        {
            var entities = await _unitOfWork.Chapters
                .GetAlll();

            var language = await _unitOfWork.Languages
                .GetById(model.LanguageId);

            var exists = entities
                .Where(x => x.Name == model.Name && x.Language.Name == language.Name)
                .FirstOrDefault();

            if (exists != null)
                return false;

            return await _unitOfWork.Chapters
                   .Create(new Chapter()
                   {
                       Name = model.Name,
                       LanguageId = model.LanguageId,
                       IsEnable = false
                   });
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _unitOfWork.Chapters
               .GetById(id);

            if (entity == null)
            {
                return false;
            }

            return await _unitOfWork.Chapters
                .Delete(entity);
        }

        public async Task<List<ChapterVM>> GetAll()
        {
            var entities = await _unitOfWork.Chapters
                .GetAlll();

            return entities.Select(x => new ChapterVM()
            {
                LanguageId = x.LanguageId,
                Name = x.Name,
                ChapterId = x.ChapterId,
                IsEnable = x.IsEnable,
                LanguageName = x.Language.Name
            }).ToList();
        }

        public async Task<ChapterVM> GetById(int id)
        {
            var entity = await _unitOfWork.Chapters
                    .GetById(id);

            if (entity == null)
            {
                return new ChapterVM();
            }

            return new ChapterVM()
            {
                LanguageId = entity.LanguageId,
                Name = entity.Name,
                IsEnable = entity.IsEnable,
                ChapterId = entity.ChapterId
            };
        }

        public async Task<bool> Update(ChapterVM model)
        {
            var entity = await _unitOfWork.Chapters
                     .GetById(model.ChapterId);

            if (entity == null)
            {
                return false;
            }

            entity.Name = model.Name;
            entity.LanguageId = model.LanguageId;
            entity.IsEnable = model.IsEnable;

            return await _unitOfWork.Chapters
                .Update(entity);
        }
    }
}