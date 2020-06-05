using itlearn.bll.api.Interfaces;
using itlearn.model.ViewModels.Advice;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace itlearn.web.ApiControllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdviceApiController : ControllerBase
    {
        private readonly IAdviceService _adviceService;

        public AdviceApiController(IAdviceService adviceService)
        {
            _adviceService = adviceService;
        }

        public ActionResult<List<AdviceVM>> GetAll()
        {
            var items = _adviceService.GetAll();
            return Ok(items);
        }

        public ActionResult<AdviceVM> GetById(int id)
        {
            var item = _adviceService.GetById(id);

            if (item == null)
            {
                return NotFound();
            }

            return Ok(item);
        }

        [HttpPost]
        public ActionResult Post([FromBody] AdviceVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var item = _adviceService.Create(model);
            return CreatedAtAction("Get", new { id = item.AdviceId }, item);
        }

        [HttpDelete]
        public ActionResult Remove(int id)
        {
            var existingItem = _adviceService.GetById(id);

            if (existingItem == null)
            {
                return NotFound();
            }

            _adviceService.Delete(id);
            return Ok();
        }
    }
}
