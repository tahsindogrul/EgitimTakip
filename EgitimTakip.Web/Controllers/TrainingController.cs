using EgitimTakip.Business.Abstract;
using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Abstcract;
using EgitimTakipRepository.Shared.Abstcract;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class TrainingController : Controller
    {
        private readonly ITrainingService _trainingService;
       

        public TrainingController(ITrainingService trainingService,IRepository
            <TrainingsSubjectsMap> subjectsRepo)
        {
            _trainingService = trainingService;
           
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll(int companyId)
        {
            return Json(new { data = _trainingService.GetAll(companyId)});

        }

        [HttpPost]
        public IActionResult Add(Training training, List<TrainingsSubjectsMap> trainingsSubjectsMaps)
        {
           
            return Ok(_trainingService.Add(training,trainingsSubjectsMaps));
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
          
            return Ok(_trainingService.Delete(id) );

        }

        [HttpPost]
        public IActionResult Update(Training training, List<TrainingsSubjectsMap> 
            trainingsSubjectsMaps)

        {
          return Ok ( _trainingService.Update(training, trainingsSubjectsMaps));
        }


        [HttpPost]
        public IActionResult UpdateAttendees(int trainingId,List<Employee> attendees)
        {
           return Ok(_trainingService.UpdateAttendees(trainingId, attendees));


        }
    }
}
