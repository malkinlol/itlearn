using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using itlearn.web.Models;
using Microsoft.AspNetCore.Authorization;
using itlearn.dal.Context;
using System.Threading.Tasks;
using itlearn.model.ViewModels.Search;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using itlearn.model.ViewModels.Account;
using itlearn.dal.Entities;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using itlearn.bll.Interfaces;
using itlearn.model.ViewModels.Theme;

namespace itlearn.web.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ApplicationContext _context;
        private readonly IPostService _postService;
        private readonly ILanguageService _languageService;
        private readonly IThemeService _themeService;
        private readonly ITestService _testService;
        private readonly IQuestionService _questionService;
        private readonly IAnswerService _answerService;

        public HomeController(IPostService postService, ApplicationContext context, UserManager<User> userManager, ILanguageService languageService, IThemeService themeService, ITestService testService, IQuestionService questionService, IAnswerService answerService)
        {
            _userManager = userManager;
            _context = context;
            _postService = postService;
            _languageService = languageService;
            _themeService = themeService;
            _testService = testService;
            _questionService = questionService;
            _answerService = answerService;
        }

        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }

            return RedirectToAction("HomeIndex");
        }

        public IActionResult HomeIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Search(string searchText)
        {
            var themes = new List<ThemeVM>();
            var searchResult = new HomeSearchVM();

            User user = null;

            var managements = new List<Management>();

            if (User.Identity.IsAuthenticated)
            {
                if (!User.Identity.Name.Equals("admin@gmail.com"))
                {
                    user = await _userManager.FindByNameAsync(User.Identity.Name);

                    managements = _context.Managements
                        .Where(x => x.UserId == user.Id)
                        .ToList();
                }
            }

            for (int i = 0; i < managements.Count; i++)
            {
                var theme = await _themeService.GetById(managements[i].ThemeId);
                themes.Add(theme);
            }

            if (string.IsNullOrEmpty(searchText))
            {
                themes = themes
                    .Where(x => x.IsEnable)
                    .ToList();

                searchResult = new HomeSearchVM()
                {
                    Themes = themes,
                    FoundItems = themes.Count
                };

                return View("Learn", searchResult);
            }

            var languages = await _languageService.GetAll();
            var language = languages.FirstOrDefault(x => x.Name.Equals(searchText) && x.IsEnable);
            if (language != null)
            {
                return View("Language", language);
            }

            themes = themes
                .Where(x => (x.Name.Contains(searchText) || x.Description.Contains(searchText) && x.IsEnable))
                .ToList();

            searchResult = new HomeSearchVM()
            {
                Themes = themes,
                FoundItems = themes.Count
            };

            return View("Learn", searchResult);
        }

        public async Task<IActionResult> Language(int languageId)
        {
            var language = await _languageService.GetById(languageId);

            return View(language);
        }

        [HttpGet]
        public async Task<IActionResult> Discussion(PostSearchVM model)
        {
            var posts = await _postService.GetBySearch(model);

            return View(posts);
        }

        public async Task<IActionResult> Theme(ThemeVM model)
        {
            User user = null;

            if (User.Identity.IsAuthenticated)
            {
                if (!User.Identity.Name.Equals("admin@gmail.com"))
                {
                    user = await _userManager.FindByNameAsync(User.Identity.Name);
                }
            }

            var theme = new ThemeVM();

            var themes = _themeService.GetAll()
                .GetAwaiter().GetResult()
                .Where(x => x.ChapterId == model.ChapterId && x.IsEnable)
                .ToList();

            var countThemes = _themeService.GetAll()
                .GetAwaiter().GetResult()
                .Where(x => x.ChapterId == model.ChapterId && x.IsEnable)
                .ToList()
                .Count();

            if (model.Index == 0)
            {
                theme = _themeService.GetAll()
                    .GetAwaiter().GetResult()
                    .Where(x => x.ChapterId == model.ChapterId && x.IsEnable)
                    .FirstOrDefault();

                theme.StatusPrevious = false;

                if (countThemes - 1 == model.Index)
                    theme.StatusNext = false;
                if (model.Index < countThemes - 1)
                    theme.StatusNext = true;
            }
            if (model.Index > 0)
            {
                theme = _themeService.GetAll()
                    .GetAwaiter().GetResult()
                    .Where(x => x.ChapterId == model.ChapterId && x.IsEnable)
                    .Skip((model.Index) * 1).Take(1).FirstOrDefault();

                var prevtheme = _themeService.GetAll()
                    .GetAwaiter().GetResult()
                    .Where(x => x.ChapterId == model.ChapterId && x.IsEnable)
                    .Skip((model.Index - 1) * 1).Take(1).FirstOrDefault();


                //пагинацию
                //bool 

                //if(user != null)
                //{
                //    var managements = _context.Managements
                //        .Where(x => x.UserId == user.Id)
                //        .ToList();

                //    management = managements.Where(x => x.ThemeId )
                //}

                theme.StatusPrevious = true;
                theme.StatusNext = model.Index == countThemes - 1 ? false : true;
            }

            theme.Index = model.Index;

            return View(theme);
        }

        public async Task<IActionResult> Learn()
        {
            var languages = await _languageService.GetAll();

            return View(languages);
        }

        public IActionResult Compile()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Test(TestQuestionVM model)
        {
            var answers = await _answerService.GetAll();

            var filterRightAnswers = answers.Where(x => x.QuestionId == model.QuestionId && x.IsRight)
                .ToList();

            var localRightAnswer = filterRightAnswers.Count;
            var localSelectRightAnswer = 0;

            model.CountRightAnswer += filterRightAnswers.Count;

            if (model.AnswerChecked != null)
            {
                for (int i = 0; i < filterRightAnswers.Count; i++)
                {
                    for (int j = 0; j < model.AnswerChecked.Count; j++)
                    {
                        if (filterRightAnswers[i].SomeAnswer.Equals(model.AnswerChecked[j]))
                        {
                            model.CountSelectRightAnswer++;
                            localSelectRightAnswer++;
                            break;
                        }
                    }
                }
            }

            var question = await _questionService.GetById(model.QuestionId);

            if (question.QuestionId == 0)
            {
                model.QuestionNumber = 1;
                TestQuestionVM.QuestionRightList = new List<model.ViewModels.Question.QuestionVM>();
                TestQuestionVM.QuestionNotRightList = new List<model.ViewModels.Question.QuestionVM>();
            }

            if (question.QuestionId != 0)
            {
                if (localRightAnswer == localSelectRightAnswer)
                {
                    TestQuestionVM.QuestionRightList.Add(question);
                }
                else
                {
                    TestQuestionVM.QuestionNotRightList.Add(question);
                }
            }

            return View(model);
        }

        public async Task<IActionResult> CourseTheme(int courseId, int themeId)
        {
            var theme = new CourseTheme();

            if (themeId != 0)
            {
                theme = await _context.CourseThemes.FirstOrDefaultAsync(x => x.CourseThemeId == themeId);
                return View(theme);
            }

            var course = await _context.Courses.Include(x => x.CourseThemes).FirstOrDefaultAsync(x => x.CourseId == courseId);

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var resultCourse = _context.ResultCourses.Where(x => x.UserId == user.Id && x.CourseId == course.CourseId);

            var countCourseTheme = course.CourseThemes.Count;
            var countCompleteTheme = resultCourse.Count(x => x.IsFinish);

            if(resultCourse.Count() == countCourseTheme)
            {
                theme = course.CourseThemes.FirstOrDefault();

                return View(theme);
            }

            //var sub = countCourseTheme - countCourseTheme;


            try
            {
                theme = course.CourseThemes.ToList()[countCompleteTheme];
            }
            catch
            {

            }

            return View(theme);
        }


        public async Task<IActionResult> SearchCourse(SearchCourseVM model)
        {
            var course = new List<Course>();

            if (!string.IsNullOrEmpty(model.Course))
            {
                var category = await _context.CategoryCourses
                    .FirstOrDefaultAsync(x => x.Name == model.Course);

                var subCategories = await _context.SubcategoryCourses
                    .Include(x => x.Courses)
                    .Where(x => x.CategoryCourseId == category.CategoryCourseId)
                    .ToListAsync();

                for (int i = 0; i < subCategories.Count; i++)
                {
                    course.AddRange(subCategories[i].Courses.Where(x => x.Approved));
                }

                return View(course);
            }

            if (model.Theme == null && model.Level == null && model.Rating == 0)
            {
                course = await _context.Courses.Where(x => x.Approved)
                    .ToListAsync();

                return View(course);
            }

            if (model.Theme != null)
            {
                for (int i = 0; i < model.Theme.Count; i++)
                {
                    course.AddRange(_context.Courses.Where(x => x.SubcategoryCourseId == model.Theme[i]));
                }
            }

            if (model.Level != null)
            {
                if (model.Level[0] == "Все")
                {
                    course.AddRange(_context.Courses.Where(x => (x.Level == "Низкий") || (x.Level == "Средний") || (x.Level == "Высокий")));
                }
                else
                {
                    for (int i = 0; i < model.Level.Count; i++)
                    {
                        course.AddRange(_context.Courses.Where(x => x.Level == model.Level[i]));
                    }
                }
            }

            if (model.Rating != 0)
            {
                course = course.Where(x => x.Rating == model.Rating).ToList();
            }

            var search = course.Select(x => x.CourseId).Distinct().ToList();
            var result = new List<Course>();

            for (int i = 0; i < search.Count; i++)
            {
                result.Add(_context.Courses.FirstOrDefault(x => x.CourseId == search[i]));
            }

            result = result.Where(x => x.Approved).ToList();

            return View(result);
        }
    }
}
