namespace TrainOrgApi.Dtos
{
    public class ExerciseRowDto
    {
        public int Number { get; set; }
        public ExerciseDto Exercise { get; set; }
        public int CountTrips { get; set; }
        public int CountReps { get; set; }
    }
}
