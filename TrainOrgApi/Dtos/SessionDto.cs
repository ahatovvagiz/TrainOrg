using System.ComponentModel.DataAnnotations;

namespace TrainOrgApi.Dtos
{
    public class SessionDto
    {
        //[Key]
        //public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        // List<ExerciseRowDto> Exercises { get; set; }
        //public UserDto? Trainer { get; set; }
        //public UsersDto User { get; set; }
        public int UserId { get; set; }
    }
}