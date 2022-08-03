using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeServiceAsync employeeServiceAsync;
        public EmployeeController(IEmployeeServiceAsync service)
        {
            employeeServiceAsync = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await employeeServiceAsync.GetAllModelAsync());
        }

        [HttpPost]
        public async Task<IActionResult> AddRegion(EmployeeModel region)
        {
            return Ok(await employeeServiceAsync.InsertModelAsync(region));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> PutRegion(int id, EmployeeModel region)
        {
            if (ModelState.IsValid && id == region.Id)
            {
                if (await employeeServiceAsync.UpdateModelAsync(region) > 0)
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
            if (await employeeServiceAsync.DeleteModelAsync(id) > 0)
            {
                var msg = new { Message = "Region has been deleted Successfully" };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}
