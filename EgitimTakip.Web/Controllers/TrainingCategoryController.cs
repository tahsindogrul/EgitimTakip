using EgitimTakip.Business.Abstract;
using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Shared.Abstcract;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class TrainingCategoryController : Controller
    {
        private readonly ITraninigCategoryService _trainingCategoryService;

        public TrainingCategoryController(ITraninigCategoryService categoryService)
        {
            _trainingCategoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new
            {
                data = _trainingCategoryService.GetAll(),
            });
        }

        [HttpPost]
        public IActionResult Add(TrainingCategory trainingCategory)
        {
            TrainingCategory category = _trainingCategoryService.Add(trainingCategory);
            if(category.Id == 0) {
                return BadRequest();
            }
            else
            {
                return Ok(category);
            }
        }


        [HttpPost]
        public IActionResult Delete(int id)
        {
            return Ok(_trainingCategoryService.Delete(id) is object);


        }
        [HttpPost]
        public IActionResult Update(TrainingCategory trainingCategory)
        {
         
            return Ok(_trainingCategoryService.Update(trainingCategory));
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_trainingCategoryService.GetById(id));
        }
         
     
    }
}
