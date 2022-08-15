using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class Debit
    {
        public int Id { get; set; }
        public DateTime BegDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Price { get; set; }


    }
}
