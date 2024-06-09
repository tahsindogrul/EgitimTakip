using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Shared.Abstcract;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class UserTypeController : Controller
    {
        private readonly IRepository<AppUserType> _repo;

        public UserTypeController(IRepository<AppUserType> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new { data = _repo.GetAll() });
        }

        [HttpPost]
        public IActionResult Add(AppUserType userType)
        {
            
            return Ok(_repo.Add(userType));
        }

        [HttpPost]
        public IActionResult Update(AppUserType userType)
        {
           
                return Ok(_repo.Update(userType));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
          
            return Ok(_repo.Delete(id)is object);
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_repo.GetById(id));
        }



    }
}
