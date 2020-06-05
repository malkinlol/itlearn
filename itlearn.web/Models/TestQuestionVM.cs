using itlearn.model.ViewModels.Question;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.web.Models
{
    public class TestQuestionVM
    {
        public int TestId { get; set; }
        public int QuestionNumber { get; set; }
        public int QuestionId { get; set; }

        public int ThemeId { get; set; }

        [BindProperty]
        public List<string> AnswerChecked { get; set; }

        public int CountRightAnswer { get; set; }
        public int CountSelectRightAnswer { get; set; }

        public static List<QuestionVM> QuestionRightList { get; set; } = new List<QuestionVM>();
        public static List<QuestionVM> QuestionNotRightList { get; set; } = new List<QuestionVM>();
        public static List<QuestionVM> RandomQuestion { get; set; } = new List<QuestionVM>();
    }
}
