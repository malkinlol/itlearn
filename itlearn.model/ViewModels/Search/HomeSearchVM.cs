using itlearn.model.ViewModels.Chapter;
using itlearn.model.ViewModels.Theme;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.model.ViewModels.Search
{
    public class HomeSearchVM
    {
        public List<ThemeVM> Themes { get; set; } = new List<ThemeVM>();
        public int FoundItems { get; set; }
        //public int PageSize { get; set; } = 1;
        //public int PageNumber { get; set; } = 1;
        //public int PageTotal { get; set; } = 1;
    }
}
