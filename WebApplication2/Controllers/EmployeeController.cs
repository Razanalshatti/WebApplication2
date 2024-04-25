using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View(EmployeeData.Employees);
        }

        public IActionResult Details(int id)
        {
            var employee = EmployeeData.Employees.First(x => x.employeeID == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }
    }
}
