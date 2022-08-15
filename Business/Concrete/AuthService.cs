using Business.Abstract;
using Business.Configuration.Auth;
using DataAccsessLayer.BaseRepository.UserRepo;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;
        private readonly IConfiguration _configuration;
        public AuthService(IUserRepository userRepository, IConfiguration configuration)
        {
            _userRepository = userRepository;
            _configuration = configuration;
        }

        public TokenProvider Login(string email, string password)
        {
            throw new NotImplementedException();
        }
    }
}
