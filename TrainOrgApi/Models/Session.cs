using System.ComponentModel.DataAnnotations;

namespace TrainOrgApi.Models
{
    public class Session
    {
        [Key]
        public int Id { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public List<ExerciseRow> ExerciseRows { get; set; }
        public User Trainer { get; set; }
        public int TrainerId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
    }
}
