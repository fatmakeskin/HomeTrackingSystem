using AutoMapper;
using BackgroundJobs.Abstract;
using Business.Abstract;
using DataAccsessLayer.BaseRepository;
using DataLayer.Entities;
using DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        protected IMapper mapper;
        protected IRepository<Users> repository;
        //protected IHangFireJob job;
        public UserService(IMapper _mapper, IRepository<Users> _repository/*IHangFireJob _job*/)
        {
            mapper = _mapper;
            repository = _repository;
            //job = _job;
        }
        #region Methods

        

        public void Add(UserDto user)
        {
            var model = mapper.Map<Users>(user);
            repository.Add(model);
            repository.SaveChanges();
            //job.DelayedJobs(model.Id, model.Name, model.Email, TimeSpan.FromSeconds(5));
        }

        public void Delete(UserDto user)
        {
            var model = mapper.Map<Users>(user);
            repository.Delete(model);
            repository.SaveChanges();
        }

        public IQueryable<UserDto> GetAll()
        {
            var model = repository.GetAll();
            var data = mapper.Map<UserDto>(model);
            return (IQueryable<UserDto>)data;
        }

        public UserDto GetById(int id)
        {
            var model = repository.GetById(id);
            var data = mapper.Map<UserDto>(model);
            return data;
        }

        public void Update(UserDto user)
        {
            var model = mapper.Map<Users>(user);
            repository.Update(model);
            repository.SaveChanges();
        }
        #endregion
    }
}
