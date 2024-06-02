using EgitimTakip.Data;
using EgitimTakip.Models;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class TrainingCategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TrainingCategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new
            {
                data = _context.TrainingCategories.Where(
            tc => !tc.IsDeleted).ToList()
            });
        }

        [HttpPost]
        public IActionResult Add(TrainingCategory trainingCategory)
        {
            try
            {
                _context.TrainingCategories.Add(trainingCategory);
                _context.SaveChanges();
                return Ok(trainingCategory);
            }
            catch (Exception ex)
            {
                //return BadRequest(ex);

                return StatusCode(500, ex.Message);
            }
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            var trainingCategory = _context.TrainingCategories.Find(id);
            trainingCategory.IsDeleted= true;
            _context.TrainingCategories.Update(trainingCategory);
            _context.SaveChanges();
            return Ok();


        }
        [HttpPost]
        public IActionResult Update(TrainingCategory trainingCategory)
        {
            _context.TrainingCategories.Update(trainingCategory);
            _context.SaveChanges();
            return Ok(trainingCategory);
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_context.TrainingCategories.Find(id));
        }

     
    }
}
