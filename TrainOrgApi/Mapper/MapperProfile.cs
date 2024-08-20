using AutoMapper;
using System.Text;
using TrainOrgApi.Dtos;
using TrainOrgApi.Models;

namespace TrainOrgApi.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<Session, SessionDto>().ReverseMap();
            CreateMap<User, UserDto>()
                .ReverseMap().ForMember(user => user.Password, opt => opt.MapFrom(userdto => StringToByteArray(userdto.Password)));
            //CreateMap<RoleId, RoleIdDto>().ReverseMap();
            CreateMap<User, UsersDto>()
                .ReverseMap();
        }
        private static byte[] StringToByteArray(string str)
        {
            return Encoding.UTF8.GetBytes(str);
        }
    }
}
