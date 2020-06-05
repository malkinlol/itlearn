using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.model.ViewModels.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace itlearn.web.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<User> _userManager;

        public PostController(IPostService postService, UserManager<User> userManager)
        {
            _postService = postService;
            _userManager = userManager;
        }

        [Authorize(Roles = "user")]
        [HttpGet]
        public IActionResult Create()
        {
            return View(new PostVM());
        }

        [Authorize(Roles = "user")]
        [HttpPost]
        public async Task<IActionResult> Create(PostVM model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByNameAsync(User.Identity.Name);

                model.UserId = user.Id;

                var result = await _postService.Create(model);

                if (!result)
                {
                    return Content("Ошибка сервера: создание поста!");
                }
                else
                {
                    if (User.Identity.Name.Equals("admin@gmail.com"))
                    {
                        return Redirect("/Admin/Index");
                    }
                    else
                    {
                        return Redirect("/Account/Discussion");
                    }
                }
            }

            return View(model);
        }

        [Authorize(Roles = "user")]
        [HttpGet]
        public async Task<IActionResult> Update(int postId)
        {
            var post = await _postService.GetById(postId);

            if (post == null)
            {
                return Content("Ошибка сервера: изменение поста!");
            }

            return View(post);
        }

        [Authorize(Roles = "user")]
        [HttpPost]
        public async Task<IActionResult> Update(PostVM model)
        {
            if (ModelState.IsValid)
            {
                var result = await _postService.Update(model);

                if (!result)
                {
                    return Content("Ошибка сервера: изменение поста!");
                }
                else
                {
                    if (User.Identity.Name.Equals("admin@gmail.com"))
                    {
                        return Redirect("/Admin/Index");
                    }
                    else
                    {
                        return Redirect("/Account/Discussion");
                    }
                }
            }

            return View(model);
        }

        [Authorize(Roles = "user, admin")]
        [HttpGet]
        public async Task<IActionResult> Delete(int postId)
        {
            var post = await _postService.GetById(postId);

            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (post.UserId == user.Id)
            {
                var result = await _postService.Delete(postId);

                if (!result)
                {
                    return Content("Ошибка сервера: удаление поста!");
                }

                if (User.Identity.Name.Equals("admin@gmail.com"))
                {
                    return Redirect("/Admin/Index");
                }
                else
                {
                    return Redirect("/Account/Discussion");
                }
            }

            return Redirect("/Account/AccessDenied");
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int postId)
        {
            var post = await _postService.GetById(postId);

            if (User.Identity.IsAuthenticated)
            {
                if (!User.Identity.Name.Equals("admin@gmail.com"))
                {
                    post.CountWatch += 1;
                }
            }

            await _postService.Update(post);

            if (post == null)
            {
                return Content("Ошибка сервера: изменение поста!");
            }

            return View(post);
        }
    }
}
