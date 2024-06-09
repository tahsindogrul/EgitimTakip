﻿using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Shared.Abstcract;
using Microsoft.AspNetCore.Mvc;

namespace EgitimTakip.Web.Controllers
{
    public class TrainingCategoryController : Controller
    {
        private readonly IRepository<TrainingCategory> _repo;

        public TrainingCategoryController(IRepository<TrainingCategory> repo)
        {
            _repo = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetAll()
        {
            return Json(new
            {
                data = _repo.GetAll(),
            });
        }

        [HttpPost]
        public IActionResult Add(TrainingCategory trainingCategory)
        {
            TrainingCategory category= _repo.Add(trainingCategory);
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
            return Ok(_repo.Delete(id) is object);


        }
        [HttpPost]
        public IActionResult Update(TrainingCategory trainingCategory)
        {
         
            return Ok(_repo.Update(trainingCategory));
        }

        [HttpPost]
        public IActionResult GetById(int id)
        {
            return Ok(_repo.GetById(id));
        }

     
    }
}
