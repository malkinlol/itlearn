using System.Collections.Generic;
using itlearn.bll.api.Interfaces;
using itlearn.model.ViewModels.Language;
using Microsoft.AspNetCore.Mvc;

namespace itlearn.web.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageApiController : ControllerBase
    {
        private readonly ILanguageService _languageService;

        public LanguageApiController(ILanguageService languageService)
        {
            _languageService = languageService;
        }

        public ActionResult<List<LanguageVM>> GetAll()
        {
            var items = _languageService.GetAll();
            return Ok(items);
        }

        public ActionResult<LanguageVM> GetById(int id)
        {
            var item = _languageService.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost]
        public ActionResult Post([FromBody] LanguageVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _languageService.Create(model);
            return CreatedAtAction("Get", new { id = item.LanguageId }, item);
        }

        [HttpDelete]
        public ActionResult Remove(int id)
        {
            var existingItem = _languageService.GetById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _languageService.Delete(id);
            return Ok();
        }
    }
}