using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Shared.Abstcract;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class CompanyController : Controller
    {
        private readonly IRepository<Company> _repo;

        public CompanyController(IRepository<Company> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult GetAll()
        {
         return Json(_repo.GetAll());  

                //return Json(_context.Companies.Where(c=>!c.IsDeleted).ToList());
        }

        [HttpPost]
        public IActionResult Add(Company company)
        {
           return Ok( _repo.Add(company));
        }

        [HttpPost]
        public IActionResult Update(Company company)
        {
            return Ok(_repo.Update(company));
        }


        //[HttpPost]
        //public IActionResult Delete(int id)
        //{ //hard delete
        //    var company = _context.Companies.Find(id);
        //    _context.Companies.Remove(company);
        //    return Ok();
        //}


        //[HttpPost]
        //public IActionResult Delete(Company company) 
        //{
        //    //hard delete
        //_context.Companies.Remove(company);
        //    _context.SaveChanges(); 
        //    return Ok();
        //}


        [HttpPost]
        public IActionResult SoftDelete(int id)
        {
            //Soft Delete
            //var company= _context.Companies.Find(id);
            // company.IsDeleted=true;
            // _context.Companies.Update(company);
            // _context.SaveChanges();
            // return Ok();

            _repo.Delete(id);
            return Ok();
        }

    }
}
