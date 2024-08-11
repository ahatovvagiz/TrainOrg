using AutoMapper;
using System.Text;
using System.Security.Cryptography;
using TrainOrgApi.Dtos;
using TrainOrgApi.Models;
using TrainOrgApi.Data;
using TrainOrgApi.Abstraction;
using Microsoft.EntityFrameworkCore;

namespace TrainOrgApi.Repository
{
    public class SessionRepository : ISessionRepository
    {
        SessionContext _sessionContext;
        IMapper _mapper;

        public SessionRepository(SessionContext sessionContext, IMapper mapper)
        {
            this._sessionContext = sessionContext;
            this._mapper = mapper;
        }

        public int AddSession(SessionDto session)
        {

            using (var context = new SessionContext())
            {
                //if (context.Sessions.Any(x => x.Id == session.Id))
                //    throw new Exception("Session is already exist!");
                //if (user.Role == UserRoleDto.Admin)
                //    if (context.Users.Any(x => x.RoleId == RoleId.Admin))
                //        throw new Exception("Admin is already exist!");

                //var entity = new User { Name = user.Name, RoleId = (RoleId)user.Role };
                var entity = _mapper.Map<Session>(session);
                //entity.
                //entity.Salt = new byte[16];
                //new Random().NextBytes(entity.Salt);
                //var data = Encoding.UTF8.GetBytes(session.Password).Concat(entity.Salt).ToArray();

                //entity.Password = new SHA512Managed().ComputeHash(data);

                context.Sessions.Add(entity);
                context.SaveChanges();

                return entity.Id;
            }

        }

        public List<Session> GetAllSessions() 
        {
            using (var context = new SessionContext())
            {
                //return await context.Sessions.ToListAsync();

                return context.Sessions.ToList();
            }
        }
    }
}