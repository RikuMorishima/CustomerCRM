using Antra.CustomerCRM.Core.Contracts.Service;
using Antra.CustomerCRM.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Antra.CustomerCRM.WebMVC.Controllers
{
    public class RegionController : Controller
    {
        IRegionServiceAsync regionServiceAsync;
        public RegionController(IRegionServiceAsync _regionServiceAsync)
        {
            regionServiceAsync = _regionServiceAsync;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(RegionModel model)
        {
            if (ModelState.IsValid)
            {
                await regionServiceAsync.InsertRegionAsync(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
    }
}
