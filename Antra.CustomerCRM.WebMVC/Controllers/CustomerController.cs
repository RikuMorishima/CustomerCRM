using Antra.CustomerCRM.Core.Contracts.Service;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebMVC.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerServiceAsync customerServiceAsync;
        public CustomerController(ICustomerServiceAsync customerServiceAsync)
        {
            this.customerServiceAsync = customerServiceAsync;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var result = await customerServiceAsync.GetModelByIdAsync(id);
            return View(result);
        }
    }
}
