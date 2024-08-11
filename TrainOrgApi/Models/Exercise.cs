namespace TrainOrgApi.Models
{
    public class Exercise
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ExerciseRow> ExerciseRow { get; set; }
    }
}
