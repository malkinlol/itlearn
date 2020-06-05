using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.dal.Interfaces;
using itlearn.model.ViewModels.Theme;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.bll.Services
{
    public class ThemeService : IThemeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ThemeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<int> Count()
        {
            return await _unitOfWork.Themes
              .Count();
        }

        public async Task<bool> Create(ThemeVM model)
        {
            //var chapter = await _unitOfWork.Chapters
            //    .GetByIdd(model.ChapterId);

            //var isEnableTheme = false;

            //if (chapter.Themes.Count == 0)
            //    isEnableTheme = true;

            return await _unitOfWork.Themes
                   .Create(new Theme()
                   {
                       Name = model.Name,
                       Description = model.Description,
                       ChapterId = model.ChapterId,
                       UpdatedDate = DateTime.Now,
                       IsEnable = false,
                       //IsEnableTheme = isEnableTheme,
                       MiniDescription = model.MiniDescription,
                       CountReadTime = model.CountReadTime,
                       CreatedDate = DateTime.Now
                   });
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _unitOfWork.Themes
               .GetById(id);

            if (entity == null)
            {
                return false;
            }

            return await _unitOfWork.Themes
                .Delete(entity);
        }

        public async Task<List<ThemeVM>> GetAll()
        {
            var entities = await _unitOfWork.Themes
                .GetAlll();

            return entities.Select(x => new ThemeVM()
            {
                ThemeId = x.ThemeId,
                Name = x.Name,
                Description = x.Description,
                MiniDescription = x.MiniDescription,
                ChapterId = x.ChapterId,
                IsEnableTheme = x.IsEnableTheme,
                UpdatedDate = x.UpdatedDate,
                IsEnable = x.IsEnable,
                ChapterName = x.Chapter.Name,
                CreatedDate = x.CreatedDate,
                LanguageId = x.Chapter.LanguageId,
                CountReadTime = x.CountReadTime
            }).ToList();
        }

        public async Task<ThemeVM> GetById(int id)
        {
            var entity = await _unitOfWork.Themes
                    .GetByIdd(id);

            if (entity == null)
            {
                return new ThemeVM();
            }

            return new ThemeVM()
            {
                ThemeId = entity.ThemeId,
                MiniDescription = entity.MiniDescription,
                UpdatedDate = entity.UpdatedDate,
                IsEnableTheme = entity.IsEnableTheme,
                Name = entity.Name,
                CountReadTime = entity.CountReadTime,
                CreatedDate = entity.CreatedDate,
                IsEnable = entity.IsEnable,
                LanguageId = entity.Chapter.LanguageId,
                Description = entity.Description,
                ChapterId = entity.ChapterId
            };
        }

        public async Task<bool> Update(ThemeVM model)
        {
            var entity = await _unitOfWork.Themes
                 .GetById(model.ThemeId);

            if (entity == null)
            {
                return false;
            }

            entity.Name = model.Name;
            entity.MiniDescription = model.MiniDescription;
            entity.Description = model.Description;
            entity.ChapterId = model.ChapterId;
            entity.UpdatedDate = DateTime.Now;
            entity.IsEnable = model.IsEnable;
            entity.CountReadTime = model.CountReadTime;

            return await _unitOfWork.Themes
                .Update(entity);
        }
    }
}