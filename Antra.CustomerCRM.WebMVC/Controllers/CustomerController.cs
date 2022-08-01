using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Antra.CustomerCRM.WebMVC.Controllers
{
    public class CustomerController : Controller
    {
        ICustomerServiceAsync customerServiceAsync;
        IRegionServiceAsync regionServiceAsync;
        public CustomerController(ICustomerServiceAsync customerServiceAsync, IRegionServiceAsync regionServiceAsync)
        {
            this.customerServiceAsync = customerServiceAsync;
            this.regionServiceAsync = regionServiceAsync;
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

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Regions = new SelectList(await regionServiceAsync.GetAllModelAsync(), "Id", "Name");
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CustomerModel model)
        {
            if (ModelState.IsValid)
            {
                await customerServiceAsync.InsertModelAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
