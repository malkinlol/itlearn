using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using itlearn.bll.Interfaces;
using itlearn.dal.Entities;
using itlearn.model.ViewModels.Comment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace itlearn.web.Controllers
{
    [Authorize]
    public class CommentController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly ICommentService _commentService;
        private readonly IPostService _postService;

        public CommentController(UserManager<User> userManager, ICommentService commentService, IPostService postService)
        {
            _userManager = userManager;
            _commentService = commentService;
            _postService = postService;
        }

        [Authorize(Roles = "user, moderator")]
        [HttpPost]
        public async Task<IActionResult> Create(CommentVM model)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            model.UserId = user.Id;

            await _commentService.Create(model);

            return Redirect($"/Post/Detail?postId={model.PostId}");
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> Delete(int commentId)
        {
            var comment = await _commentService.GetById(commentId);
            var post = await _postService.GetById(comment.PostId);

            await _commentService.Delete(commentId);

            return Redirect($"/Post/Detail?postId={post.PostId}");
        }
    }
}