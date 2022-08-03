using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly IVendorServiceAsync vendorServiceAsync;
        public VendorController(IVendorServiceAsync service)
        {
            vendorServiceAsync = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await vendorServiceAsync.GetAllModelAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion(VendorModel region)
        {
            return Ok(await vendorServiceAsync.InsertModelAsync(region));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> PutRegion(int id, VendorModel region)
        {
            if (ModelState.IsValid && id == region.Id)
            {
                if (await vendorServiceAsync.UpdateModelAsync(region) > 0)
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
            if (await vendorServiceAsync.DeleteModelAsync(id) > 0)
            {
                var msg = new { Message = "Region has been deleted Successfully" };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}
