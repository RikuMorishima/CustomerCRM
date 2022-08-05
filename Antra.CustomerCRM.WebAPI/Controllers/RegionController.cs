using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        IRegionServiceAsync regionServiceAsync;
        public RegionController(IRegionServiceAsync regionServiceAsync)
        {
            this.regionServiceAsync = regionServiceAsync;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await regionServiceAsync.GetAllModelAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion(RegionModel region)
        {
            return Ok(await regionServiceAsync.InsertModelAsync(region));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> PutRegion(int id, RegionModel region)
        {
            if (ModelState.IsValid && id == region.Id)
            {
                if (await regionServiceAsync.UpdateModelAsync(region) >0)
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
            if (await regionServiceAsync.DeleteModelAsync(id) > 0)
            {
                var msg = new { Message = "Region has been deleted Successfully" };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}
