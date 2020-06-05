using System;
using System.Collections.Generic;
using System.Text;

namespace itlearn.model.ViewModels.Advice
{
    public class AdviceVM
    {
        public int AdviceId { get; set; }
        public int TestId { get; set; }
        public string Status { get; set; }
        public string Link { get; set; }
        public DateTime Date { get; set; }
        public string UserId { get; set; }
    }
}
