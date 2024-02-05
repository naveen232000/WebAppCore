using Microsoft.AspNetCore.Mvc;
using WebAppCore.Models;

namespace WebAppCore.Controllers
{
    public class EmployeeController : Controller
    {
        static List<Employee> emp = new List<Employee>() {
        new Employee(){Id=1,Name="Sam",Designation="Manager",Salary=56329,Doj=new DateTime(year:2023,month:12,day:23) },
        new Employee(){Id=2,Name="Jon",Designation="HR",Salary=45623,Doj=new DateTime(year:2023,month:11,day:15) },
        new Employee(){Id=3,Name="Leena",Designation="Developer",Salary=23659,Doj=new DateTime(year:2023,month:10,day:20) },
        new Employee(){Id=4,Name="Taj",Designation="Tester",Salary=32564,Doj=new DateTime(year:2024,month:01,day:23) },
        new Employee(){Id=5,Name="Dhee",Designation="TeamLead",Salary=26549,Doj=new DateTime(year:2024,month:02,day:02) },
        };
        public IActionResult Index()
        {
            return View(emp);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View(new Employee());
        }
        [HttpPost]
        public IActionResult Create(Employee e)
        {
            if (ModelState.IsValid)
            {
                emp.Add(e);
                return RedirectToAction("Index");
            }
            return View(emp);
        }
        public IActionResult Delete(int id)
        {
            Employee e=emp.SingleOrDefault(e=>e.Id==id);
            
            return View(e);
        }
        [HttpPost]
        public IActionResult Delete(int? id)
        {
            Employee e = emp.SingleOrDefault(e => e.Id == id);
            if (e!=null)
            {
                emp.Remove(e);
                
                return RedirectToAction("Index");
            }
            return View(emp);
        }
    }
}
