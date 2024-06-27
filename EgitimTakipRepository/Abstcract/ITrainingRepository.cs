using EgitimTakip.Models;
using EgitimTakipRepository.Shared.Abstcract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimTakipRepository.Abstcract
{
    public interface ITrainingRepository:IRepository<Training>
    {
        ICollection<Training> GetAll(int companyId);

        Training Add(Training training, List<TrainingsSubjectsMap> trainingsSubjectsMaps);


        void UpdateAttendees(int trainingId, List<Employee> employees);

        void RemoveEmployee(int trainingId,Employee employee);

    }
}
