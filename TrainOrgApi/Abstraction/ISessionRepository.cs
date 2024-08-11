using TrainOrgApi.Dtos;
using TrainOrgApi.Models;

namespace TrainOrgApi.Abstraction
{
    public interface ISessionRepository
    {
        int AddSession(SessionDto session);
        List<Session> GetAllSessions();
    }
}
