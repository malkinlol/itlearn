using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.model.ViewModels.Account
{
    public class LeaderVM
    {
        public string SearchText { get; set; }

        public List<UserVM> Users { get; set; } = new List<UserVM>();
    }
}
