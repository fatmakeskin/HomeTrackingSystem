using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Users
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TckNo { get; set; }
        public string LicensePlate { get; set; }
        public string Status { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public int Price { get; set; }
        public RoleEnum roleEnum { get; set; }
        public UserPassword Password { get; set; }

        public IQueryable<Apertment> Apertment { get; set; }
    }
}
