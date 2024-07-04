using EgitimTakip.Business.Abstract;
using EgitimTakip.Models;
using EgitimTakipRepository.Shared.Abstcract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimTakip.Business.Concrete
{
    public class TraininigCategoryService : ITraninigCategoryService
    {
        private readonly IRepository<TrainingCategory> _repository;

        public TraininigCategoryService(IRepository<TrainingCategory> repository)
        {
            _repository = repository;
        }

        public TrainingCategory Add(TrainingCategory category)
        {
            return _repository.Add(category);
        }

        public bool Delete(int categoryId)
        {
             _repository.Delete(categoryId);
            return true;
        }

        public IQueryable<TrainingCategory> GetAll()
        {
            return _repository.GetAll();
        }

        public TrainingCategory GetById(int categoryId)
        {
            return _repository.GetById(categoryId);
        }

        public TrainingCategory Update(TrainingCategory category)
        {
            return _repository.Update(category);
        }
    }
}
