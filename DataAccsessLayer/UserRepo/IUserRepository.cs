using DataLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccsessLayer.BaseRepository.UserRepo
{
    public interface IUserRepository :IRepository<Users>
    {
       public Users GetUserWithPassword(string email);
    }
}
