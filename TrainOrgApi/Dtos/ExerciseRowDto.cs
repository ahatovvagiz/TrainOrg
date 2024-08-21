using TrainOrgApi.Models;

namespace TrainOrgApi.Dtos
{
    public class ExerciseRowDto
    {
        public int SessionId { get; set; }
        public Session Session { get; set; }
        public int Number { get; set; }
        public ExerciseDto Exercise { get; set; }
        public int CountTrips { get; set; }
        public int CountReps { get; set; }
    }
}
