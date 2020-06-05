using itlearn.bll.api.Interfaces;
using itlearn.model.ViewModels.Story;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.web.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoryApiController : ControllerBase
    {
        private readonly IStoryService _storyService;

        public StoryApiController(IStoryService storyService)
        {
            _storyService = storyService;
        }

        public ActionResult<List<StoryVM>> GetAll()
        {
            var items = _storyService.GetAll();
            return Ok(items);
        }

        public ActionResult<StoryVM> GetById(int id)
        {
            var item = _storyService.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost]
        public ActionResult Post([FromBody] StoryVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _storyService.Create(model);
            return CreatedAtAction("Get", new { id = item.StoryId }, item);
        }

        [HttpDelete]
        public ActionResult Remove(int id)
        {
            var existingItem = _storyService.GetById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _storyService.Delete(id);
            return Ok();
        }
    }
}
