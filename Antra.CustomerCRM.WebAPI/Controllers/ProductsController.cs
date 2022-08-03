using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductServiceAsync productServiceAsync;
        public ProductsController(IProductServiceAsync service)
        {
            productServiceAsync = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await productServiceAsync.GetAllModelAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion(ProductModel region)
        {
            return Ok(await productServiceAsync.InsertModelAsync(region));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> PutRegion(int id, ProductModel region)
        {
            if (ModelState.IsValid && id == region.Id)
            {
                if (await productServiceAsync.UpdateModelAsync(region) > 0)
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
            if (await productServiceAsync.DeleteModelAsync(id) > 0)
            {
                var msg = new { Message = "Region has been deleted Successfully" };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}
