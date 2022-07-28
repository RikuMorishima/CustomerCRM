using Microsoft.AspNetCore.Mvc;
using Antra.CustomerCRM.WebMVC.Models;
namespace Antra.CustomerCRM.WebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.UserName = "Riku"; // need to put into (in this case "Index.cshtml") @ViewBag.UserName

            List<string> countries = new List<string>
            {
                "USA", "UK", "Germany", "China", "India"
            };
            ViewBag.Countries = countries;

            List<Employee> employees = new List<Employee>()
            {
                new Employee() {Id=1,FirstName="Jane",LastName="Doe"},
                new Employee() {Id=2,FirstName="William",LastName="Doe"},
                new Employee() {Id=3,FirstName="Alice",LastName="Doe"},
                new Employee() {Id=4,FirstName="James",LastName="Anderson"}
            };
            return View(employees);
        }
    }
}
