using TrainOrgApi.Models;
using TrainOrgApi.Dtos;

namespace TrainOrgApi.Abstraction
{
    public interface IUserRepository
    {
        int AddUser(UserDto user);
        RoleId CheckUser(LoginDto login);
        int GetUsers();
    }
}