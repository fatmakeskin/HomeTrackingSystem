using DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        IQueryable<UserDto> GetAll();
        UserDto GetById(int id);
        void Add(UserDto user);
        void Update(UserDto user);
        void Delete(UserDto user);
        
    }
}
