using itlearn.dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace itlearn.dal.Interfaces
{
    public interface IThemeRepository
    : IBaseRepository<Theme>
    {
        Task<List<Theme>> GetAlll();
        Task<Theme> GetByIdd(int themeId);
    }
}
