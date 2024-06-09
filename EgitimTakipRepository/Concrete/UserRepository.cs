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
    public class UserRepository : Repository<AppUser>, IUserRepository
    {
        public UserRepository(ApplicationDbContext context):base(context)
        {
            
        }
        public AppUser CheckUser(string username, string password)
        {
           return base.GetFirstOrDefault(u=>u.UserName== username && u.Password == password && !
            u.IsDeleted);
        }
    }
}
