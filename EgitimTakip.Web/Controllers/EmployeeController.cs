using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Abstcract;
using EgitimTakipRepository.Shared.Abstcract;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeRepository _repo;

        public EmployeeController(IEmployeeRepository repo)
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
            return Json(new { data = _repo.GetAll(companyId) });
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
