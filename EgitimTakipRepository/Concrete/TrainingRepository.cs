using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Abstcract;
using EgitimTakipRepository.Shared.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimTakipRepository.Concrete
{
    public class TrainingRepository : Repository<Training>, ITrainingRepository
    {
        
        public TrainingRepository(ApplicationDbContext context):base(context) 
        {
       
        }

        public Training Add(Training training, List<TrainingsSubjectsMap> trainingsSubjectsMaps)
        {
            base.Add(training);
            foreach (var item in trainingsSubjectsMaps)
            {
                item.TrainingId = training.Id;

            }
            training.TrainingsSubjectsMap = trainingsSubjectsMaps;
            base.Update(training);
            
            return training;
        }

        public void AddEmployees(int trainingId, List<Employee> employees)
        {
            Training training = base.GetById(trainingId);
            training.Employees.ToList().AddRange(employees);
            base.Update(training); 
        }

        public ICollection<Training> GetAll(int companyId)
        {
            return base.GetAll().Where(t=>t.CompanyId == companyId).ToList();
        }

        public void RemoveEmployee(int trainingId, Employee employee)
        {
            Training training= GetById(trainingId);
            training.Employees.Remove(employee);
            base.Update(training);
        }
    }
}
