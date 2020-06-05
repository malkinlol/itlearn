using itlearn.bll.Interfaces;
using itlearn.dal.Context;
using itlearn.dal.Entities;
using itlearn.model.Responses;
using itlearn.model.ViewModels.Account;
using itlearn.model.ViewModels.Achievement;
using itlearn.model.ViewModels.Advice;
using itlearn.model.ViewModels.Course;
using itlearn.model.ViewModels.Story;
using itlearn.model.ViewModels.Theme;
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
using System.Text;
using System.Threading.Tasks;

namespace itlearn.web.Controllers
{
    public class AccountController : Controller
    {
        private readonly ApplicationContext _context;
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;
        private readonly IAchievementService _achievementService;
        private readonly IAdviceService _adviceService;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IStoryServices _storyServices;
        private readonly ILanguageService _languageService;

        public AccountController(ApplicationContext context, ILanguageService languageService, IAchievementService achievementService, IAdviceService adviceService, IStoryServices storyServices, UserManager<User> userManager, SignInManager<User> signInManager, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _achievementService = achievementService;
            _adviceService = adviceService;
            _storyServices = storyServices;
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
            _languageService = languageService;
        }

        [HttpGet]
        public async Task<IActionResult> Stats()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var model = new UserVM()
            {
                UserId = user.Id,
                AboutMe = user.AboutMe,
                Avatar = user.Avatar,
                Country = user.Country,
                Email = user.Email,
                Experience = user.Experience,
                Facebook = user.Facebook,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LinkedIn = user.LinkedIn,
                SelectedEducationId = user.SelectedEducationId,
                SelectedJobId = user.SelectedJobId,
                Site = user.Site,
                Phone = user.PhoneNumber,
                Twitter = user.Twitter
            };


            return View(model);
        }

        [HttpGet]
        public IActionResult QA(int courseThemeId)
        {
            return View(courseThemeId);
        }

        [HttpPost]
        public IActionResult CreateQA(CourseThemeQA model)
        {
            _context.CourseThemeQAs.Add(model);
            _context.SaveChanges();

            var courseTheme = _context.CourseThemes
                .Where(x => x.CourseThemeId == model.CourseThemeId)
                .FirstOrDefault();

            var course = _context.Courses
                .FirstOrDefault(x => x.CourseId == courseTheme.CourseId);

            return View("DetailCourse", course);
        }

        [HttpGet]
        public IActionResult DeleteQA(int qa, int courseThemeId)
        {
            var qaModel = _context.CourseThemeQAs
                .FirstOrDefault(x => x.QAId == qa);

            _context.CourseThemeQAs.Remove(qaModel);
            _context.SaveChanges();

            var courseTheme = _context.CourseThemes
                .Where(x => x.CourseThemeId == courseThemeId)
                .FirstOrDefault();

            var course = _context.Courses
                .FirstOrDefault(x => x.CourseId == courseTheme.CourseId);



            return View("DetailCourse", course);
        }

        [HttpPost]
        public async Task<IActionResult> UserLearnLanguage(UserLearn model)
        {
            _context.UserLearns.Add(model);
            _context.SaveChanges();

            var language = await _languageService.GetById(model.LanguageId);

            return Redirect($"/Home/Language?languageId={model.LanguageId}");
        }

        [HttpGet]
        public IActionResult Discussion()
        {
            return View();
        }



        [HttpPost]
        public async Task<IActionResult> ReadNotification()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            user.IsNotificationRead = true;

            await _context.SaveChangesAsync();

            return Redirect("/Home/Index");
        }

        public async Task<IActionResult> SubscribeCourse(SubscribeCourse model)
        {
            await _context.SubscribeCourses.AddAsync(model);
            await _context.SaveChangesAsync();

            var course = await _context.Courses
                .FirstOrDefaultAsync(x => x.CourseId == model.CourseId);

            return Redirect("/Account/Course");
        }

        [Authorize]
        public async Task<IActionResult> ResultCourseCreate(ResultCourseVM model)
        {
            //model.IsFinish = true;

            var qaModel = _context.CourseThemeQAs
                .FirstOrDefault(x => x.CourseThemeId == model.ThemeId && x.QAId == model.QAId);

            if (model.Answer == qaModel.Answer)
            {
                model.IsFinish = true;
            }
            else
            {
                var courseTheme = _context.CourseThemes
                    .FirstOrDefault(x => x.CourseThemeId == model.ThemeId);

                return Redirect("/Home/CourseTheme?courseId=" + courseTheme.CourseId);
            }

            var res = _context.ResultCourses
                .Count(x => x.CourseId == model.CourseId && x.UserId == model.UserId && x.IsFinish);

            var countThemes = _context.CourseThemes.Count(x => x.CourseId == model.CourseId);

            var course = _context.Courses.Find(model.CourseId);

            if (res == 0)
                res = 1;

            var exp = res * course.Experience / countThemes;

            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.Experience += exp;

            var theme = _context.CourseThemes.Find(model.ThemeId);

            user.Time += theme.TimeRead;

            var result = new ResultCourse { ThemeId = model.ThemeId, CourseId = model.CourseId, IsFinish = model.IsFinish, UserId = model.UserId };

            await _context.ResultCourses.AddAsync(result);
            await _context.SaveChangesAsync();


            return Redirect($"/Home/CourseTheme?courseId={model.CourseId}&themeId={model.ThemeId}");
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> Story(ThemeVM model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var story = new StoryVM
            {
                UserId = user.Id,
                Link = $"/Home/Theme?themeId={model.ThemeId}&index={model.Index}&chapterId={model.ChapterId}",
                ThemeId = model.ThemeId
            };

            await _storyServices.Create(story);

            return Redirect($"/Home/Theme?themeId={model.ThemeId}&index={model.Index}&chapterId={model.ChapterId}");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCommentCourse(CourseComment model)
        {
            model.CommentDate = DateTime.Now;
            model.isAdmin = false;

            await _context.CourseComments.AddAsync(model);
            await _context.SaveChangesAsync();

            var course = await _context.Courses
                .FirstOrDefaultAsync(x => x.CourseId == model.CourseId);

            return Redirect("/Home/SearchCourse");
        }

        public IActionResult Comment()
        {
            return View();
        }

        [Authorize(Roles = "user, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteStory(StoryVM model)
        {
            await _storyServices.Delete(model.StoryId);

            return Redirect("/Account/Stats");
        }

        [Authorize(Roles = "user, moderator")]
        [HttpPost]
        public async Task<IActionResult> SaveAchievement(AchievementVM model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            model.UserId = user.Id;

            await _achievementService.Create(model);

            return Redirect("/Account/Profile");
        }

        [Authorize(Roles = "user, moderator")]
        [HttpPost]
        public async Task<IActionResult> SaveAdvice(AdviceVM model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            model.UserId = user.Id;

            await _adviceService.Create(model);

            return Redirect("/Account/Profile");
        }

        [Authorize(Roles = "user, moderator")]
        [HttpPost]
        public async Task<IActionResult> DeleteAchievement(AchievementVM model)
        {
            await _achievementService.Delete(model.AchievementId);

            return Redirect("/Account/Profile");
        }

        [Authorize(Roles = "user, moderator")]
        [HttpPost]
        public async Task<IActionResult> DeleteAdvice(AdviceVM model)
        {
            await _adviceService.Delete(model.AdviceId);

            return Redirect("/Account/Profile");
        }

        [Authorize(Roles = "user, moderator")]
        [HttpPost]
        public async Task<IActionResult> EditNotification(string[] Tags)
        {
            var tags = string.Empty;

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (Tags != null)
                tags = ConvertStringArrayToString(Tags);

            user.Tags = tags;

            await _context.SaveChangesAsync();

            return Redirect("/Account/Profile");
        }

        [HttpGet]
        public IActionResult AccessDenied(string returnUrl = null)
        {
            return View(new ReturnUrlResponse { ReturnUrl = returnUrl });
        }

        private string ConvertStringArrayToString(string[] array)
        {
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {
                builder.Append(value);
                builder.Append('.');
            }
            return builder.ToString();
        }

        private string[] ConvertStringToStringArray(string tags)
        {
            string[] tagsArray = tags.Split(new char[] { '.', ',', ' ' });
            return tagsArray;
        }

        //Готово
        [HttpGet]
        public IActionResult Login(string returnUrl = null)
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Index");
            }

            return View(new LoginVM { ReturnUrl = returnUrl });
        }

        //Готово
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(model.Email);
                if (user != null)
                {
                    if (!await _userManager.IsEmailConfirmedAsync(user))
                    {
                        ModelState.AddModelError(string.Empty, "Вы не подтвердили свой email");
                        return View(model);
                    }
                }

                var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, true, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", "Неправильный логин и (или) пароль");
                }
            }

            return View(model);
        }

        //Готово
        [HttpGet]
        public IActionResult Register()
        {
            if (User.Identity.IsAuthenticated)
            {
                return Redirect("/Home/Index");
            }

            return View(new RegisterVM());
        }

        //Готово
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> ConfirmEmail(string userId, string code)
        {
            if (userId == null || code == null)
            {
                return View("Error");
            }
            var user = await _userManager.FindByIdAsync(userId);
            if (user == null)
            {
                return View("Error");
            }
            var result = await _userManager.ConfirmEmailAsync(user, code);
            if (result.Succeeded)
                return RedirectToAction("Login", "Account");
            else
                return View("Error");
        }

        //Готово
        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM model)
        {
            if (ModelState.IsValid)
            {
                var user = new User { Email = model.Email, UserName = model.Email, UserDateCreate = DateTime.Now };
                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user, "user");

                    var code = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                    var callbackUrl = Url.Action(
                        "ConfirmEmail",
                        "Account",
                        new { userId = user.Id, code = code },
                        protocol: HttpContext.Request.Scheme);

                    #region Отправка сообщения
                    MailAddress from = new MailAddress("mytestmail1999@gmail.com", "IT Learn");
                    MailAddress to = new MailAddress(model.Email);
                    MailMessage m = new MailMessage(from, to);
                    m.Subject = "Свяжитесь со мной";
                    m.Body = $"<p>Подтвердите регистрацию, перейдя по ссылке: <a href='{callbackUrl}'>link</a></p>";
                    m.IsBodyHtml = true;
                    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                    smtp.UseDefaultCredentials = true;
                    smtp.Credentials = new NetworkCredential("mytestmail1999@gmail.com", "Ktgtkm1999");
                    smtp.EnableSsl = true;
                    smtp.Send(m);

                    smtp.Dispose();
                    #endregion

                    return RedirectToAction("Login");
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }
            return View(model);
        }

        //Готово
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return Redirect("/Home/Index");
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> Profile()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var model = new UserVM()
            {
                UserId = user.Id,
                AboutMe = user.AboutMe,
                Avatar = user.Avatar,
                Country = user.Country,
                Email = user.Email,
                Experience = user.Experience,
                Facebook = user.Facebook,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LinkedIn = user.LinkedIn,
                SelectedEducationId = user.SelectedEducationId,
                SelectedJobId = user.SelectedJobId,
                Site = user.Site,
                Phone = user.PhoneNumber,
                Twitter = user.Twitter,
                Time = user.Time
            };

            return View(model);
        }

        //Готово
        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> EditProfile()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var model = new UserVM()
            {
                UserId = user.Id,
                AboutMe = user.AboutMe,
                Avatar = user.Avatar,
                Country = user.Country,
                Email = user.Email,
                Experience = user.Experience,
                Facebook = user.Facebook,
                FirstName = user.FirstName,
                LastName = user.LastName,
                LinkedIn = user.LinkedIn,
                SelectedEducationId = user.SelectedEducationId,
                SelectedJobId = user.SelectedJobId,
                Site = user.Site,
                Phone = user.PhoneNumber,
                Twitter = user.Twitter
            };

            return View(model);
        }

        //Готово
        [HttpPost]
        public async Task<IActionResult> EditProfile(UserVM model, IFormFile uploadedFile)
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            if (uploadedFile != null)
            {
                string path = "/images/avatars/" + Guid.NewGuid() + "_" + uploadedFile.FileName;
                using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                user.Avatar = path;
            }

            user.AboutMe = model.AboutMe;
            user.Country = model.Country;
            user.Facebook = model.Facebook;
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.LinkedIn = model.LinkedIn;
            user.PhoneNumber = model.Phone;
            user.SelectedEducationId = model.SelectedEducationId;
            user.SelectedJobId = model.SelectedJobId;
            user.Site = model.Site;
            user.Twitter = model.Twitter;
            model.Avatar = user.Avatar;

            await _context.SaveChangesAsync();

            return View(model);
        }

        //Готово
        public async Task<IActionResult> Education()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var educations = await _context.Educations
                .Where(x => x.UserId == user.Id)
                .ToListAsync();

            return View(educations);
        }

        //Готово
        [Authorize(Roles = "user, moderator")]
        public IActionResult CreateEducation()
        {
            return View(new EducationVM());
        }

        //Готово
        [HttpPost]
        public async Task<IActionResult> CreateEducation(EducationVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.DateTo > model.DateFrom)
                {
                    ModelState.AddModelError("", "Дата поступления может быть больше даты выпуска!");
                    return View(model);
                }

                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                var education = new Education
                {
                    UserId = user.Id,
                    Name = model.Name,
                    Position = model.Position,
                    Site = model.Site,
                    IsGraduate = model.IsGraduate,
                    DateFrom = model.DateFrom,
                    DateTo = model.DateTo
                };

                await _context.Educations.AddAsync(education);
                await _context.SaveChangesAsync();

                return RedirectToAction("Education");
            }

            ModelState.AddModelError("", "Заполните все поля!");

            return View(model);
        }

        //Готово
        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> EditEducation(int educationId)
        {
            var education = await _context.Educations.FirstOrDefaultAsync(x => x.EducationId == educationId);

            return View(new EducationVM()
            {
                EducationId = education.EducationId,
                UserId = education.UserId,
                Name = education.Name,
                Position = education.Position,
                Site = education.Site,
                IsGraduate = education.IsGraduate,
                DateFrom = education.DateFrom,
                DateTo = education.DateTo
            });
        }

        //Готово
        [HttpPost]
        public async Task<IActionResult> EditEducation(EducationVM model)
        {
            if (ModelState.IsValid)
            {
                if (model.DateTo > model.DateFrom)
                {
                    ModelState.AddModelError("", "Дата поступления может быть больше даты выпуска!");
                    return View(model);
                }

                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                var education = await _context.Educations.FirstOrDefaultAsync(x => x.EducationId == model.EducationId);

                education.Name = model.Name;
                education.Position = model.Position;
                education.Site = model.Site;
                education.IsGraduate = model.IsGraduate;
                education.DateFrom = model.DateFrom;
                education.DateTo = model.DateTo;

                await _context.SaveChangesAsync();

                return RedirectToAction("Education");
            }

            ModelState.AddModelError("", "Заполните все поля!");

            return View(model);
        }

        //Готово
        [Authorize(Roles = "user, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteEducation(int educationId)
        {
            var education = await _context.Educations.FirstOrDefaultAsync(x => x.EducationId == educationId);

            _context.Educations.Remove(education);
            await _context.SaveChangesAsync();

            return RedirectToAction("Education");
        }

        //Готово
        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> Job()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var jobs = await _context.Jobs
                .Where(x => x.UserId == user.Id)
                .ToListAsync();

            return View(jobs);
        }

        //Готово
        [Authorize(Roles = "user, moderator")]
        public IActionResult CreateJob()
        {
            return View(new JobVM());
        }

        //Готово
        [HttpPost]
        public async Task<IActionResult> CreateJob(JobVM model)
        {
            if (ModelState.IsValid)
            {
                //if (model.DateTo > model.DateFrom)
                //{
                //    ModelState.AddModelError("", "Дата начала может быть больше даты окончания!");
                //    return View(model);
                //}

                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                var job = new Job
                {
                    UserId = user.Id,
                    Name = model.Name,
                    Position = model.Position,
                    Site = model.Site,
                    DateFrom = model.DateFrom,
                    Info = model.Info,
                    DateTo = model.DateTo
                };

                await _context.Jobs.AddAsync(job);
                await _context.SaveChangesAsync();

                return RedirectToAction("Job");
            }

            ModelState.AddModelError("", "Поле 'Начало работы' должно быть заполнено!");

            return View(model);
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> EditJob(int jobId)
        {
            var job = await _context.Jobs.FirstOrDefaultAsync(x => x.JobId == jobId);

            return View(new JobVM()
            {
                JobId = job.JobId,
                UserId = job.UserId,
                Name = job.Name,
                Position = job.Position,
                Info = job.Info,
                Site = job.Site,
                DateFrom = job.DateFrom,
                DateTo = job.DateTo
            });
        }

        //Готово
        [HttpPost]
        public async Task<IActionResult> EditJob(JobVM model)
        {
            if (ModelState.IsValid)
            {
                //if (model.DateTo > model.DateFrom)
                //{
                //    ModelState.AddModelError("", "Дата начала может быть больше даты окончания!");
                //    return View(model);
                //}

                var user = await _userManager.FindByEmailAsync(User.Identity.Name);

                var job = await _context.Jobs.FirstOrDefaultAsync(x => x.JobId == model.JobId);

                job.Name = model.Name;
                job.Position = model.Position;
                job.Site = model.Site;
                job.DateFrom = model.DateFrom;
                job.DateTo = model.DateTo;

                await _context.SaveChangesAsync();

                return RedirectToAction("Job");
            }

            ModelState.AddModelError("", "Заполните все поля!");

            return View(model);
        }

        //Готово
        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> DeleteJob(int jobId)
        {
            var job = await _context.Jobs.FirstOrDefaultAsync(x => x.JobId == jobId);

            _context.Jobs.Remove(job);
            await _context.SaveChangesAsync();

            return RedirectToAction("Job");
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> Course()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var courses = await _context.Courses.ToListAsync();
            var subscribeCourses = await _context.SubscribeCourses
                .Where(x => x.UserId == user.Id)
                .ToListAsync();

            var response = new List<Course>();

            for (int i = 0; i < courses.Count; i++)
            {
                for (int j = 0; j < subscribeCourses.Count; j++)
                {
                    if (subscribeCourses[j].CourseId == courses[i].CourseId)
                    {
                        response.Add(courses[i]);
                        break;
                    }
                }
            }

            return View(response);
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> MyCourse()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var courses = await _context.Courses
                .Include(x => x.CourseComments)
                .Where(x => x.UserId == user.Id)
                .ToListAsync();

            return View(courses);
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> CompleteCourse()
        {
            var user = await _userManager.FindByEmailAsync(User.Identity.Name);

            var courses = await _context.Courses
                .Where(x => x.UserId == user.Id)
                .ToListAsync();

            return View(courses);
        }

        [Authorize(Roles = "user, moderator")]
        public IActionResult CreateCourse()
        {
            return View(new CourseVM());
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourse(CourseVM model, IFormFile uploadedFile)
        {
            if (uploadedFile == null)
            {
                ModelState.AddModelError("", "Выберите аватар!");
                return View(model);
            }

            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);

                var course = new Course();

                string path = "/images/courses/" + Guid.NewGuid() + "_" + uploadedFile.FileName;
                using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                course.Avatar = path;

                course.UserId = user.Id;
                course.Experience = model.Experience;
                course.Level = model.Level;
                course.LongDescription = model.LongDescription;
                course.ShortDesciption = model.ShortDesciption;
                course.SubcategoryCourseId = model.SubcategoryCourseId;
                course.Title = model.Title;
                course.CreatedDate = DateTime.Now;
                course.UpdatedDate = DateTime.Now;
                course.Approved = false;
                course.Enrolled = 0;

                await _context.Courses.AddAsync(course);
                await _context.SaveChangesAsync();

                return RedirectToAction("MyCourse");
            }

            return View(model);
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> EditCourse(int courseId)
        {
            var model = await _context.Courses.FindAsync(courseId);

            var course = new CourseVM();

            course.CourseId = model.CourseId;
            course.Experience = model.Experience;
            course.Level = model.Level;
            course.LongDescription = model.LongDescription;
            course.ShortDesciption = model.ShortDesciption;
            course.SubcategoryCourseId = model.SubcategoryCourseId;
            course.Title = model.Title;

            return View(course);
        }

        [HttpPost]
        public async Task<IActionResult> EditCourse(CourseVM model, IFormFile uploadedFile)
        {
            if (ModelState.IsValid)
            {
                var course = await _context.Courses.FirstOrDefaultAsync(x => x.CourseId == model.CourseId);

                if (uploadedFile != null)
                {
                    string path = "/images/courses/" + Guid.NewGuid() + "_" + uploadedFile.FileName;
                    using (var fileStream = new FileStream(_webHostEnvironment.WebRootPath + path, FileMode.Create))
                    {
                        await uploadedFile.CopyToAsync(fileStream);
                    }
                    course.Avatar = path;
                }

                course.Experience = model.Experience;
                course.Level = model.Level;
                course.LongDescription = model.LongDescription;
                course.Rating = model.Rating;
                course.ShortDesciption = model.ShortDesciption;
                course.SubcategoryCourseId = model.SubcategoryCourseId;
                course.UpdatedDate = DateTime.Now;
                course.Title = model.Title;

                await _context.SaveChangesAsync();

                return RedirectToAction("MyCourse");
            }

            return View(model);
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> DetailCourse(int courseId)
        {
            var course = await _context.Courses.FindAsync(courseId);

            return View(course);
        }

        [Authorize(Roles = "user, moderator")]
        public async Task<IActionResult> DeleteCourse(int courseId)
        {
            var course = await _context.Courses.FindAsync(courseId);

            _context.Courses.Remove(course);
            await _context.SaveChangesAsync();

            return RedirectToAction("MyCourse");
        }

        [HttpPost]
        public async Task<IActionResult> CreateLearn(CourseLearn model)
        {
            var courseLearn = new CourseLearn { CourseId = model.CourseId, Learn = model.Learn };

            await _context.CourseLearn.AddAsync(courseLearn);
            await _context.SaveChangesAsync();

            var course = await _context.Courses.FindAsync(model.CourseId);

            return View("DetailCourse", course);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRequirement(Requirement model)
        {
            var requirement = new Requirement { CourseId = model.CourseId, RequireName = model.RequireName };

            await _context.Requirements.AddAsync(requirement);
            await _context.SaveChangesAsync();

            var course = await _context.Courses.FindAsync(model.CourseId);

            return View("DetailCourse", course);
        }

        [Authorize(Roles = "user, moderator")]
        [HttpGet]
        public IActionResult CreateCourseTheme(int courseId)
        {
            return View(new CourseThemeVM { CourseId = courseId });
        }

        [HttpPost]
        public async Task<IActionResult> CreateCourseTheme(CourseThemeVM model)
        {
            if (ModelState.IsValid)
            {
                var courseTheme = new CourseTheme();
                courseTheme.CourseId = model.CourseId;
                courseTheme.Title = model.Title;
                courseTheme.Description = model.Description;
                courseTheme.TimeRead = model.TimeRead;
                courseTheme.PublishDate = DateTime.Now;
                courseTheme.UpdateDate = DateTime.Now;

                await _context.CourseThemes.AddAsync(courseTheme);
                await _context.SaveChangesAsync();

                var course = await _context.Courses.FindAsync(model.CourseId);
                return View("DetailCourse", course);
            }

            return View(model);
        }

        [Authorize(Roles = "user, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteCourseTheme(int courseThemeId)
        {
            var courseTheme = await _context.CourseThemes.FirstOrDefaultAsync(x => x.CourseThemeId == courseThemeId);
            var courseId = courseTheme.CourseId;

            _context.CourseThemes.Remove(courseTheme);
            await _context.SaveChangesAsync();

            var course = await _context.Courses.FindAsync(courseId);
            return View("DetailCourse", course);
        }

        [Authorize(Roles = "user, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteRequirement(int requirementId)
        {
            var req = await _context.Requirements.FirstOrDefaultAsync(x => x.RequirementId == requirementId);
            var courseId = req.CourseId;

            _context.Requirements.Remove(req);
            await _context.SaveChangesAsync();

            var course = await _context.Courses.FindAsync(courseId);
            return View("DetailCourse", course);
        }

        [Authorize(Roles = "user, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteCourseLearn(int courseLearnId)
        {
            var courseLearn = await _context.CourseLearn.FirstOrDefaultAsync(x => x.CourseLearnId == courseLearnId);
            var courseId = courseLearn.CourseId;

            _context.CourseLearn.Remove(courseLearn);
            await _context.SaveChangesAsync();

            var course = await _context.Courses.FindAsync(courseId);
            return View("DetailCourse", course);
        }

        [Authorize(Roles = "user, moderator")]
        [HttpGet]
        public async Task<IActionResult> DeleteCourseComment(int commentId)
        {
            var comment = await _context.CourseComments.FirstOrDefaultAsync(x => x.CommentId == commentId);

            _context.CourseComments.Remove(comment);
            await _context.SaveChangesAsync();

            return Redirect("/Account/Comment");
        }

        [Authorize(Roles = "user, moderator")]
        [HttpGet]
        public async Task<IActionResult> EditCourseTheme(int courseThemeId)
        {
            var courseTheme = await _context.CourseThemes.FirstOrDefaultAsync(x => x.CourseThemeId == courseThemeId);

            return View(new CourseThemeVM() { CourseId = courseTheme.CourseId, CourseThemeId = courseTheme.CourseThemeId, Description = courseTheme.Description, TimeRead = courseTheme.TimeRead, Title = courseTheme.Title });
        }

        [HttpPost]
        public async Task<IActionResult> EditCourseTheme(CourseThemeVM model)
        {
            if (ModelState.IsValid)
            {
                var courseTheme = await _context.CourseThemes.FirstOrDefaultAsync(x => x.CourseThemeId == model.CourseThemeId);

                courseTheme.Description = model.Description;
                courseTheme.TimeRead = model.TimeRead;
                courseTheme.Title = model.Title;
                courseTheme.UpdateDate = DateTime.Now;

                await _context.SaveChangesAsync();

                var course = await _context.Courses.FindAsync(courseTheme.CourseId);
                return View("DetailCourse", course);
            }

            return View(model);
        }


        public async Task<IActionResult> ShowUserProfile(string email)
        {
            if (email.Equals(User.Identity.Name))
            {
                return Redirect("/Account/Profile");
            }

            var user = await _userManager.FindByNameAsync(email);

            return View(user);
        }

        public async Task<IActionResult> Leaders(string searchText)
        {
            var leaders = new LeaderVM();
            var users = _context.Users.Include(x => x.Courses).OrderByDescending(x => x.Experience).ToList();

            if (string.IsNullOrEmpty(searchText))
            {
                leaders.SearchText = string.Empty;
                leaders.Users.AddRange(users.Select(x => new UserVM() { Email = x.Email, Country = x.Country, Experience = x.Experience, CountCourse = x.Courses.Where(x => x.Approved).Count() }));

                return View(leaders);
            }

            users = _context.Users.Include(x => x.Courses).Where(x => x.Country == searchText || x.FirstName == searchText || x.LastName == searchText || x.Email == searchText).OrderByDescending(x => x.Experience).ToList();

            leaders.SearchText = searchText;
            leaders.Users.AddRange(users.Select(x => new UserVM() { Email = x.Email, Experience = x.Experience, Country = x.Country, CountCourse = x.Courses.Where(x => x.Approved).Count() }));

            return View(leaders);
        }
        public IActionResult ShowCourse(int courseId)
        {
            var course = _context.Courses.Include(x => x.User).FirstOrDefault(x => x.CourseId == courseId);

            var user = _userManager.FindByNameAsync(User.Identity.Name)
                .GetAwaiter().GetResult();

            course.User.Id = user.Id;

            return View(course);
        }
    }
}
