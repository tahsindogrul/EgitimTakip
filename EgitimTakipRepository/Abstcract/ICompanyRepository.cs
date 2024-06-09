using EgitimTakip.Models;
using EgitimTakipRepository.Shared.Abstcract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgitimTakipRepository.Abstcract
{
    public interface ICompanyRepository : IRepository<Company>

    {
        ICollection<Company> GetAll(int userId);
    }
}

