using DataLayer.Entities;
using DTO.Apertment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApertmentService
    {
        IEnumerable<ApertmentDto> GetAll();
        ApertmentDto GetById(int id);
        void Add(ApertmentDto apertment);
        void Update(ApertmentDto apertment);
        void Delete(ApertmentDto apertment);

    }
}
