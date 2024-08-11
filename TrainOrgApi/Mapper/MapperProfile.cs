using AutoMapper;
using TrainOrgApi.Dtos;
using TrainOrgApi.Models;

namespace TrainOrgApi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Session, SessionDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
        }
    }
}
