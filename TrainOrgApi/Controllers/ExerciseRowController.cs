using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using TrainOrgApi.Abstraction;
using TrainOrgApi.Dtos;
using TrainOrgApi.Models;

namespace TrainOrgApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseRowController : ControllerBase
    {
        private readonly IExerciseRowRepository _repository;

        public ExerciseRowController(IExerciseRowRepository repository)
        {
            _repository = repository;
        }

        [HttpPost("add_exercise_row")]
        public ActionResult<int> AddExerciseRow(ExerciseRowDto exerciseRowDto)
        {
            try
            {
                return Ok(_repository.AddExerciseRow(exerciseRowDto));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpPost("save_all_exercise_rows_by_session")]
        public ActionResult<int> SaveAllExerciseRowsBySession(int sessionId, List<ExerciseRowDto> exerciseRows)
        {
            try
            {
                return Ok(_repository.SaveAllExerciseRowsBySession(sessionId, exerciseRows));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }
        //[HttpPost("check_user")]
        //public ActionResult<RoleId> CheckUser(LoginDto login)
        //{
        //    try
        //    {
        //        return Ok(_repository.CheckUser(login));
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(409, ex.Message);
        //    }
        //}

        //[HttpGet("get_users")]
        //public ActionResult<int> GetUsers()
        //{
        //    try
        //    {
        //        return Ok(_repository.GetUsers());
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(409, ex.Message);
        //    }
        //}

        //[HttpGet("get_all_users")]
        //public ActionResult<int> GetAllUsers()
        //{
        //    try
        //    {
        //        return Ok(_repository.GetAllUsers());
        //    }
        //    catch (Exception ex)
        //    {
        //        return StatusCode(409, ex.Message);
        //    }
        //}
    }
}
