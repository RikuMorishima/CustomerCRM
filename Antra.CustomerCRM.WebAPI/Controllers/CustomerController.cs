using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        ICustomerServiceAsync customerService;
        public CustomerController(ICustomerServiceAsync customerService)
        {
            this.customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await customerService.GetAllModelAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await customerService.GetModelByIdAsync(id));
        }

        [HttpPost]
        public async Task<IActionResult> Insert(CustomerModel customerModel)
        {
            return Ok(await customerService.InsertModelAsync(customerModel));
        }

        [HttpPut]
        [Route("{id:int}")]
        public async Task<IActionResult> Update(CustomerModel model, int id)
        {
            if (ModelState.IsValid && id == model.Id)
            {
                if (await customerService.UpdateModelAsync(model) > 0)
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
            if (await customerService.DeleteModelAsync(id) > 0)
            {
                var msg = new { Message = "Region has been deleted Successfully" };
                return Ok(msg);
            }
            return BadRequest();
        }
    }
}
