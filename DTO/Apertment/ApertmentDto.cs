using DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Apertment
{
    public class ApertmentDto
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Blok { get; set; }
        public int FloorNum { get; set; }
        public int DoorNum { get; set; }
        public string FlatType { get; set; }

        //public int UserId { get; set; }
        //public UserDto UserDto { get; set; }
    }
}
