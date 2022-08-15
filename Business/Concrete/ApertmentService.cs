using AutoMapper;
using Business.Abstract;
using DataAccsessLayer.BaseRepository;
using DataLayer.Entities;
using DTO.Apertment;
using DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApertmentService : IApertmentService
    {
        private IMapper mapper;
        private IRepository<Apertment> repository;
        public ApertmentService(IMapper _mapper, IRepository<Apertment> _repository)
        {
            mapper = _mapper;
            repository = _repository;
        }

        public void Add(ApertmentDto apertment)
        {
            var model=mapper.Map<Apertment>(apertment);
            repository.Add(model);
            repository.SaveChanges();
        }

        public void Delete(ApertmentDto apertment)
        {
            var model = mapper.Map<Apertment>(apertment);
            repository.Delete(model);
            repository.SaveChanges();
        }

        public IEnumerable<ApertmentDto> GetAll()
        {
            var model=repository.GetAll();
            var data=mapper.Map<Apertment>(model);
            return (IEnumerable<ApertmentDto>)data;
        }

        public ApertmentDto GetById(int id)
        {
            var data=repository.GetById(id);
            var model=mapper.Map<ApertmentDto>(data);
            return model;
            
        }

        public void Update(ApertmentDto apertment)
        {
            var model=mapper.Map<Apertment>(apertment);
            repository.Update(model);
            repository.SaveChanges();
        }
    }
}
