using DataLayer.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Entities
{
    public class CollectiveDebit
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public CollectiveDebitEnum collectiveDebit  { get; set; }
        public double Price { get; set; }

    }
}
