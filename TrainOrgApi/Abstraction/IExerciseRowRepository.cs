using TrainOrgApi.Dtos;
using TrainOrgApi.Models;

namespace TrainOrgApi.Abstraction
{
    public interface IExerciseRowRepository
    {
        List<ExerciseRow> GetAllExerciseRow();
        int AddExerciseRow(ExerciseRowDto exerciseRow);
        public int SaveAllExerciseRowsBySession(int sessionId, List<ExerciseRowDto> exerciseRows);
    }
}
