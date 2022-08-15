using AutoMapper;
using DataLayer.Entities;
using DTO.Apertment;
using DTO.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Users, UserDto>();
            CreateMap<UserDto, Users>();

            CreateMap<Apertment, ApertmentDto>()
               .ForMember(x => x.UserName, y => y.MapFrom(z => z.Users.Name + " " + z.Users.Surname));
            CreateMap<ApertmentDto, Apertment>();                
           


        }
    }
}


