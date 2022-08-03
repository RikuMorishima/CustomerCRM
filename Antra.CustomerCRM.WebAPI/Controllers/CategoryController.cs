using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryServiceAsync categoryServiceAsync;
        public CategoryController(ICategoryServiceAsync categoryServiceAsync)
        {
            this.categoryServiceAsync = categoryServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await categoryServiceAsync.GetAllModelAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion(CategoryModel region)
        {
            return Ok(await categoryServiceAsync.InsertModelAsync(region));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> PutRegion(int id, CategoryModel region)
        {
            if (ModelState.IsValid && id == region.Id)
            {
                if (await categoryServiceAsync.UpdateModelAsync(region) > 0)
                {
                    return Ok(region);
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> DeleteRegion(int id)
        {
            if (await categoryServiceAsync.DeleteModelAsync(id) > 0)
            {
                var msg = new { Message = "Region has been deleted Successfully" };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}
