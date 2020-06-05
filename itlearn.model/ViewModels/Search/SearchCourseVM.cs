using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.model.ViewModels.Search
{
    public class SearchCourseVM
    {
        public string Course { get; set; }
        [BindProperty]
        public List<int> Theme { get; set; }
        public int Rating { get; set; }
        [BindProperty]
        public List<string> Level { get; set; }
    }
}
