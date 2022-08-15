using DTO.Apertment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.User
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TckNo { get; set; }
        public string LicensePlate { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int Price{get; set;}
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public IQueryable<ApertmentDto>? Apertments { get; set; }
    }
}
