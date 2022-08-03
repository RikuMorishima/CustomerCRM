using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippersController : ControllerBase
    {
        private readonly IShipperServiceAsync shipperServiceAsync;
        public ShippersController(IShipperServiceAsync service)
        {
            shipperServiceAsync = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await shipperServiceAsync.GetAllModelAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await shipperServiceAsync.GetModelByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(ShipperModel model)
        {
            return Ok(await shipperServiceAsync.InsertModelAsync(model));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(ShipperModel model, int id)
        {
            if (ModelState.IsValid && id == model.Id)
            {
                if (await shipperServiceAsync.UpdateModelAsync(model) > 0)
                {
                    return Ok(model);
                }
            }
            return BadRequest();
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            if (await shipperServiceAsync.DeleteModelAsync(id) > 0)
            {
                var msg = new { Message = "Region has been deleted Successfully" };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}
