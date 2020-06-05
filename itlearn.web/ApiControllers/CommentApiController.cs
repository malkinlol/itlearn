using itlearn.bll.api.Interfaces;
using itlearn.model.ViewModels.Comment;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace itlearn.web.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentApiController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentApiController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public ActionResult<List<CommentVM>> GetAll()
        {
            var items = _commentService.GetAll();
            return Ok(items);
        }

        public ActionResult<CommentVM> GetById(int id)
        {
            var item = _commentService.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost]
        public ActionResult Post([FromBody] CommentVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _commentService.Create(model);
            return CreatedAtAction("Get", new { id = item.CommentId }, item);
        }

        [HttpDelete]
        public ActionResult Remove(int id)
        {
            var existingItem = _commentService.GetById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _commentService.Delete(id);
            return Ok();
        }
    }
}
