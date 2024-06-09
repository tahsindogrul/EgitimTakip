using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Abstcract;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class TrainingController : Controller
    {
        private readonly ITrainingRepository _repo;

        public TrainingController(ITrainingRepository repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll(int companyId)
        {
            return Json(new { data = _repo.GetAll(companyId)});

        }

        [HttpPost]
        public IActionResult Add(Training training, List<TrainingsSubjectsMap> trainingsSubjectsMaps)
        {
           
            return Ok(_repo.Add(training,trainingsSubjectsMaps));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
          
            return Ok(_repo.Delete(id) is object);

        }

        [HttpPost]
        public IActionResult Update(Training training, List<TrainingsSubjectsMap> 
            trainingsSubjectsMaps)

        {
            training.TrainingsSubjectsMap = new List<TrainingsSubjectsMap>();
            _repo.Update(training);

            training.TrainingsSubjectsMap=trainingsSubjectsMaps;
            return Ok(_repo.Update(training));
        }
    }
}
