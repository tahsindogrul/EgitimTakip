using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Shared.Abstcract;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IRepository<Employee> _repo;

        public EmployeeController(IRepository<Employee> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetAll(int companyId)
        {
            var result = _context.Employees.Where(e => e.CompanyId == companyId && e.IsDeleted==false).ToList();
            return Json(new { data = result });
        }




        [HttpPost]
        public IActionResult Add(Employee employee)
        {
            return Ok(_repo.Add(employee));



        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
          return Ok(_repo.Delete(id) is object);
        }

        [HttpPost]
        public IActionResult Update(Employee employee)
        {
            return Ok(_repo.Update(employee));
        }


     
    }
}
