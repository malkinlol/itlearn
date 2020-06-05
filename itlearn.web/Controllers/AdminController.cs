using itlearn.bll.Interfaces;
using itlearn.dal.Context;
using itlearn.dal.Entities;
using itlearn.model.ViewModels.Answer;
using itlearn.model.ViewModels.Chapter;
using itlearn.model.ViewModels.Language;
using itlearn.model.ViewModels.Notification;
using itlearn.model.ViewModels.Question;
using itlearn.model.ViewModels.Test;
using itlearn.model.ViewModels.Theme;
using itlearn.web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace itlearn.web.Controllers
{
    [Authorize(Roles = "admin, moderator")]
    public class AdminController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly ApplicationContext _context;
        private readonly ILanguageService _languageService;
        private readonly IChapterService _chapterService;
        private readonly IThemeService _themeService;
        private readonly ITestService _testService;
        private readonly IQuestionService _questionService;
        private readonly IAnswerService _answerService;
        private readonly INotificationService _notificationService;
        private readonly ICommentService _commentService;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdminController(ApplicationContext context,
               UserManager<User> userManager,
               RoleManager<IdentityRole> roleManager,
               ILanguageService languageService,
               IChapterService chapterService,
               IThemeService themeService,
               ITestService testService,
               IQuestionService questionService,
               IAnswerService answerService,
               INotificationService notificationService,
               ICommentService commentService,
               IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
            _languageService = languageService;
            _chapterService = chapterService;
            _themeService = themeService;
            _testService = testService;
            _questionService = questionService;
            _answerService = answerService;
            _notificationService = notificationService;
            _commentService = commentService;
            _webHostEnvironment = webHostEnvironment;
        }

       

        public async Task<IActionResult> Course()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var courses = _context.Courses
                .Where(x => !x.Approved && x.UserId != user.Id)
                .ToList();

            return View(courses);
        }

        public async Task<IActionResult> CourseDetail(int courseId)
        {
            var course = await _context.Courses
                .FirstOrDefaultAsync(x => x.CourseId == courseId);

            return View(course);
        }

        public async Task<IActionResult> CourseThemeDetail(int themeId)
        {
            var theme = await _context.CourseThemes
                .FirstOrDefaultAsync(x => x.CourseThemeId == themeId);

            return View(theme);
        }

        [HttpGet]
        public async Task<IActionResult> CourseApprove(int courseId)
        {
            var course = await _context.Courses
                .FirstOrDefaultAsync(x => x.CourseId == courseId);

            course.Approved = true;

            await _context.SaveChangesAsync();

            return RedirectToAction("Course");
        }

        [HttpPost]
        public async Task<IActionResult> CourseCommentCreate(CourseComment model)
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var courseId = model.CourseId;

            model.UserId = user.Id;
            model.isAdmin = true;
            model.CommentDate = DateTime.Now;

            await _context.CourseComments.AddAsync(model);
            await _context.SaveChangesAsync();

            var course = await _context.Courses
                .FirstOrDefaultAsync(x => x.CourseId == courseId);

            return View("CourseDetail", course);


        }

        [HttpGet]
        public async Task<IActionResult> CourseCommentDelete(int commentId)
        {
            var comment = await _context.CourseComments
                .FirstOrDefaultAsync(x => x.CommentId == commentId);

            var courseId = comment.CourseId;

            _context.CourseComments.Remove(comment);
            await _context.SaveChangesAsync();

            var course = await _context.Courses
                .FirstOrDefaultAsync(x => x.CourseId == courseId);

            return View("CourseDetail", course);
        }
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            return View();
        }

        //---LANGUAGE

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult Language()
        {
            return View();
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DetailLanguage(int languageId)
        {
            var language = await _languageService.GetById(languageId);

            return View(language);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult CreateLanguage()
        {
            return View(new LanguageVM());
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> CreateLanguage(LanguageVM model, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                string path = "/images/admin/" + Guid.NewGuid() + "_" + uploadedFile.FileName;
                using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                model.Avatar = path;

                var result = await _languageService.Create(model);

                if (!result)
                    ModelState.AddModelError("", "Такой язык программирования уже есть!");
                else
                    return Redirect("/Admin/Language");

            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> EditLanguage(int languageId)
        {
            var language = await _languageService.GetById(languageId);

            return View(language);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> EditLanguage(LanguageVM model, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                if (uploadedFile != null)
                {
                    string path = "/images/admin/" + Guid.NewGuid() + "_" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    model.Avatar = path;
                }
                var result = await _languageService.Update(model);

                if (!result)
                    ModelState.AddModelError("", "Ошибка сервера");
                else
                    return Redirect("/Admin/Language");
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteLanguage(int languageId)
        {
            var result = await _languageService.Delete(languageId);

            return Redirect("/Admin/Language");
        }

        //---СHAPTER

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult Chapter()
        {
            return View();
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DetailChapter(int chapterId)
        {
            var chapter = await _chapterService.GetById(chapterId);

            return View(chapter);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult CreateChapter(int languageId)
        {
            return View(new ChapterVM() { LanguageId = languageId });
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> CreateChapter(ChapterVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.LanguageId == 0)
                {
                    ModelState.AddModelError("", "Выберите язык программирования!");
                }
                else
                {
                    var result = await _chapterService.Create(model);

                    if (!result)
                        ModelState.AddModelError("", "Такая глава у этого языка программирования уже есть!");
                    else
                        return Redirect("/Admin/Chapter");
                }
            }

            model.Languages = await _languageService.GetAll();

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> EditChapter(int chapterId)
        {
            var chapter = await _chapterService.GetById(chapterId);

            return View(chapter);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> EditChapter(ChapterVM model)
        {
            if (ModelState.IsValid)
            {
                var chapter = await _chapterService.GetById(model.ChapterId);

                if (chapter.Name == model.Name && chapter.LanguageId == model.LanguageId && chapter.IsEnable == model.IsEnable)
                {
                    ModelState.AddModelError("", "Сделайте изменение!");
                    return View(model);
                }

                var result = await _chapterService.Update(model);

                if (!result)
                    ModelState.AddModelError("", "Ошибка сервера!");
                else
                    return Redirect("/Admin/Chapter");
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteChapter(int chapterId)
        {
            var result = await _chapterService.Delete(chapterId);

            return Redirect("/Admin/Chapter");
        }

        //---THEME

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult Theme()
        {
            return View();
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DetailTheme(int themeId)
        {
            var theme = await _themeService.GetById(themeId);

            return View(theme);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult CreateTheme(int chapterId)
        {
            return View(new ThemeVM() { ChapterId = chapterId });
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> CreateTheme(ThemeVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.ChapterId == 0)
                {
                    ModelState.AddModelError("", "Выберите главу, к которой относится тема!");
                }
                else
                {
                    var result = await _themeService.Create(model);

                    if (!result)
                        ModelState.AddModelError("", "Такая тема у этой главы уже есть!");
                    else
                        return Redirect("/Admin/Theme");
                }
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> EditTheme(int themeId)
        {
            var theme = await _themeService.GetById(themeId);

            return View(theme);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> EditTheme(ThemeVM model)
        {
            if (ModelState.IsValid)
            {
                var theme = await _themeService.GetById(model.ThemeId);

                if (theme.Name == model.Name && theme.Description == model.Description && theme.ChapterId == model.ChapterId && theme.IsEnable == model.IsEnable)
                {
                    ModelState.AddModelError("", "Сделайте изменение!");
                    return View(model);
                }

                await _themeService.Update(model);

                return Redirect("/Admin/Theme");
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteTheme(int themeId)
        {
            var result = await _themeService.Delete(themeId);

            return Redirect("/Admin/Theme");
        }

        //---TEST

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult Test()
        {
            return View();
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DetailTest(int testId)
        {
            var test = await _testService.GetById(testId);

            return View(test);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult CreateTest(int themeId)
        {
            return View(new TestVM() { ThemeId = themeId });
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> CreateTest(TestVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await _testService.Create(model);

                if (!result)
                {
                    ModelState.AddModelError(string.Empty, "У темы уже есть тест!");
                    return View(model);
                }

                return Redirect("/Admin/Test");
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> EditTest(int testId)
        {
            var test = await _testService.GetById(testId);

            return View(test);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> EditTest(TestVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await _testService.Update(model);

                return Redirect("/Admin/Test");
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteTest(int testId)
        {
            await _testService.Delete(testId);

            return Redirect("/Admin/Test");
        }

        //---QUESTION

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult Question()
        {
            return View();
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DetailQuestion(int questionId)
        {
            var question = await _questionService.GetById(questionId);

            return View(question);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult CreateQuestion(int testId)
        {
            return View(new QuestionVM() { TestId = testId });
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> CreateQuestion(QuestionVM model, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                if (uploadedFile != null)
                {
                    string path = "/images/questions/" + Guid.NewGuid() + "_" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    model.Avatar = path;
                }

                var result = await _questionService.Create(model);

                return Redirect("/Admin/Question");
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> EditQuestion(int questionId)
        {
            var question = await _questionService.GetById(questionId);

            return View(question);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> EditQuestion(QuestionVM model, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                if (uploadedFile != null)
                {
                    string path = "/images/questions/" + Guid.NewGuid() + "_" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    model.Avatar = path;
                }

                var question = await _questionService.GetById(model.QuestionId);

                if (question.SomeQuestion == model.SomeQuestion && question.TestId == model.TestId)
                {
                    ModelState.AddModelError(string.Empty, "Сделайте изменения!");
                    return View(model);
                }

                var result = await _questionService.Update(model);

                if (!result)
                    ModelState.AddModelError(string.Empty, "У этого теста есть такой вопрос!");
                else
                    return Redirect("/Admin/Question");
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteQuestion(int questionId)
        {
            await _questionService.Delete(questionId);

            return Redirect("/Admin/Question");
        }

        //---ANSWER

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult Answer()
        {
            return View();
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DetailAnswer(int answerId)
        {
            var answer = await _answerService.GetById(answerId);

            return View(answer);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult CreateAnswer(int questionId)
        {
            return View(new AnswerVM() { QuestionId = questionId });
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> CreateAnswer(AnswerVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await _answerService.Create(model);

                return Redirect("/Admin/Answer");
            }

            return View(model);
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteAnswer(int answerId)
        {
            await _answerService.Delete(answerId);

            return Redirect("/Admin/Answer");
        }

        //---NOTIFICATION

        [Authorize(Roles = "admin, moderator")]
        public IActionResult Notification()
        {
            return View();
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpPost]
        public async Task<IActionResult> CreateNotification(NotificationVM model)
        {
            var result = await _notificationService.Create(model);

            if (!result)
            {
                return Content("Ошибка сервера: создания уведомления!");
            }

            //EMAIL

            var users = _context.Users
                .Where(x => x.Tags.Contains(model.Language))
                .ToList();

            for (int i = 0; i < users.Count; i++)
            {
                var code = await _userManager.GenerateEmailConfirmationTokenAsync(users[i]);
                var callbackUrl = Url.Action(
                    "ConfirmEmail",
                    "Account",
                    new { userId = users[i].Id, code = code },
                    protocol: HttpContext.Request.Scheme);

                // отправитель - устанавливаем адрес и отображаемое в письме имя
                MailAddress from = new MailAddress("mytestmail1999@gmail.com", "IT Learn");
                // кому отправляем
                MailAddress to = new MailAddress(users[i].Email);
                // создаем объект сообщения
                MailMessage m = new MailMessage(from, to);
                // тема письма
                m.Subject = "Информация!";
                // текст письма
                m.Body = $"<h3>Язык программироваиня: {model.Language}</h3><br/><p>{model.Message}</p>";
                // письмо представляет код html
                m.IsBodyHtml = true;
                // адрес smtp-сервера и порт, с которого будем отправлять письмо
                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                // логин и пароль
                smtp.UseDefaultCredentials = true;

                smtp.Credentials = new NetworkCredential("mytestmail1999@gmail.com", "Ktgtkm1999");

                smtp.EnableSsl = true;
                smtp.Send(m);

                smtp.Dispose();
            }



            var allUsers = _context.Users.ToList();

            for (int i = 0; i < allUsers.Count(); i++)
                allUsers[i].IsNotificationRead = false;

            _context.Users.UpdateRange(allUsers);
            await _context.SaveChangesAsync();

            return Redirect("/Admin/Notification");
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteNotification(int notificationId)
        {
            await _notificationService.Delete(notificationId);

            return Redirect("/Admin/Notification");
        }

        //---COMMENT

        [Authorize(Roles = "admin, moderator")]
        public IActionResult Comment()
        {
            return View();
        }

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public async Task<IActionResult> Delete(int commentId)
        {
            await _commentService.Delete(commentId);

            return Redirect("/Admin/Comment");
        }

        //---USER

        [Authorize(Roles = "admin, moderator")]
        [HttpGet]
        public IActionResult UserView() => View(_userManager.Users.ToList());

        [Authorize(Roles = "admin")]
        [HttpGet]
        public async Task<ActionResult> DeleteUser(string userId)
        {
            User user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                IdentityResult result = await _userManager.DeleteAsync(user);
            }
            return RedirectToAction("UserView");
        }

        [Authorize(Roles = "admin")]
        public async Task<IActionResult> EditUserRole(string userId)
        {
            // получаем пользователя
            User user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                // получем список ролей пользователя
                var userRoles = await _userManager.GetRolesAsync(user);
                var allRoles = _roleManager.Roles.ToList();
                ChangeRoleViewModel model = new ChangeRoleViewModel
                {
                    UserId = user.Id,
                    UserEmail = user.Email,
                    UserRoles = userRoles,
                    AllRoles = allRoles
                };
                return View(model);
            }

            return NotFound();
        }

        [Authorize(Roles = "admin")]
        [HttpPost]
        public async Task<IActionResult> EditUserRole(string userId, List<string> roles)
        {
            // получаем пользователя
            User user = await _userManager.FindByIdAsync(userId);
            if (user != null)
            {
                // получем список ролей пользователя
                var userRoles = await _userManager.GetRolesAsync(user);
                // получаем все роли
                var allRoles = _roleManager.Roles.ToList();
                // получаем список ролей, которые были добавлены
                var addedRoles = roles.Except(userRoles);
                // получаем роли, которые были удалены
                var removedRoles = userRoles.Except(roles);

                await _userManager.AddToRolesAsync(user, addedRoles);

                await _userManager.RemoveFromRolesAsync(user, removedRoles);

                return RedirectToAction("UserView");
            }

            return NotFound();
        }
    }
}
