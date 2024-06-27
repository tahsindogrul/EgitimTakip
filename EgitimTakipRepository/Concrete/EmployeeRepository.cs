using EgitimTakip.Data;
using EgitimTakip.Models;
using EgitimTakipRepository.Abstcract;
using EgitimTakipRepository.Shared.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimTakipRepository.Concrete
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        

        public EmployeeRepository(ApplicationDbContext context ):base(context)
        {
            
        }

        public ICollection<Employee> GetAll(int companyId)
        {
            return base.GetAll(emp => emp.CompanyId == companyId).ToList();

            //return _context.Employees.Where(e=>!e.IsDeleted && e.CompanyId==companyId).ToList();
        
        }
    }
}
