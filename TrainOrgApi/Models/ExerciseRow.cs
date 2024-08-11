namespace TrainOrgApi.Models
{
    public class ExerciseRow
    {
        public int Id { get; set; }
        public virtual Exercise? Exercise { get; set; } //упражнение
        public int ExerciseId { get; set; }
        public int CountTrips { get; set; } //количество подходов
        public int CountReps { get; set; } //количество повторений
        // Связь с Session
        public int SessionId { get; set; }
        public Session Session { get; set; }
    }
}
