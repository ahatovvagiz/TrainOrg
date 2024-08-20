using Microsoft.AspNetCore.Mvc;
using TrainOrgApi.Dtos;
using TrainOrgApi.Models;
using TrainOrgApi.Abstraction;

namespace TrainOrgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("add_user")]
        public ActionResult<int> AddUser(UserDto user)
        {
            try
            {
                return Ok(_repository.AddUser(user));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpPost("check_user")]
        public ActionResult<RoleId> CheckUser(LoginDto login)
        {
            try
            {
                return Ok(_repository.CheckUser(login));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpGet("get_users")]
        public ActionResult<int> GetUsers()
        {
            try
            {
                return Ok(_repository.GetUsers());
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpGet("get_all_users")]
        public ActionResult<int> GetAllUsers()
        {
            try
            {
                return Ok(_repository.GetAllUsers());
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }
    }
}