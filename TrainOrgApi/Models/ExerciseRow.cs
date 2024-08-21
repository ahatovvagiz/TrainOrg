namespace TrainOrgApi.Models
{
    public class ExerciseRow
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public int SessionId { get; set; }
        public Session Session { get; set; }
        public int ExerciseId { get; set; } //упражнение
        public Exercise Exercise { get; set; }
        public int CountTrips { get; set; } //количество подходов
        public int CountReps { get; set; } //количество повторений
        // Связь с Session       
    }
}
