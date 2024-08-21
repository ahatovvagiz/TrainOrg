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
    public class ExerciseRowRepository : IExerciseRowRepository
    {
        SessionContext _sessionContext;
        IMapper _mapper;

        public ExerciseRowRepository(SessionContext sessionContext, IMapper mapper)
        {
            this._sessionContext = sessionContext;
            this._mapper = mapper;
        }
        public List<ExerciseRow> GetAllExerciseRow()
        {
            using (var context = new SessionContext())
            {
                //return await context.Sessions.ToListAsync();

                return context.ExerciseRows.ToList();
            }
        }
        public int AddExerciseRow(ExerciseRowDto exerciseRow)
        {
            using (var context = new SessionContext())
            {
                //if (context.Sessions.Any(x => x.Id == session.Id))
                //    throw new Exception("Session is already exist!");
                //if (user.Role == UserRoleDto.Admin)
                //    if (context.Users.Any(x => x.RoleId == RoleId.Admin))
                //        throw new Exception("Admin is already exist!");

                //var entity = new User { Name = user.Name, RoleId = (RoleId)user.Role };
                var entity = _mapper.Map<ExerciseRow>(exerciseRow);
                //entity.
                //entity.Salt = new byte[16];
                //new Random().NextBytes(entity.Salt);
                //var data = Encoding.UTF8.GetBytes(session.Password).Concat(entity.Salt).ToArray();

                //entity.Password = new SHA512Managed().ComputeHash(data);

                context.ExerciseRows.Add(entity);
                context.SaveChanges();

                return entity.Id;
            }

        }

        public int SaveAllExerciseRowsBySession(int sessionId, List<ExerciseRowDto> exerciseRows)
        {
            using (var context = new SessionContext())
            {
                // Check if the session exists, if necessary
                // if (!context.Sessions.Any(x => x.Id == exerciseRow.SessionId))
                //     throw new Exception("Session does not exist!");

                // Remove all existing exercise rows for the specified session
                var existingExerciseRows = context.ExerciseRows
                                                   .Where(x => x.SessionId == sessionId);

                context.ExerciseRows.RemoveRange(existingExerciseRows);

                // Map the DTO to the entity
                var entity = _mapper.Map<ExerciseRow>(exerciseRows);

                // Add the new exercise row
                context.ExerciseRows.Add(entity);

                // Save changes to the database
                context.SaveChanges();

                // Return the ID of the newly added exercise row
                return entity.Id;
            }
        }

        //public int AddExerciseRow(ExerciseRowDto exerciseRow)
        //{
        //    using (var context = new SessionContext())
        //    {
        //        //if (context.Sessions.Any(x => x.Id == session.Id))
        //        //    throw new Exception("Session is already exist!");
        //        //if (user.Role == UserRoleDto.Admin)
        //        //    if (context.Users.Any(x => x.RoleId == RoleId.Admin))
        //        //        throw new Exception("Admin is already exist!");

        //        //var entity = new User { Name = user.Name, RoleId = (RoleId)user.Role };
        //        var entity = _mapper.Map<ExerciseRow>(exerciseRow);
        //        //entity.
        //        //entity.Salt = new byte[16];
        //        //new Random().NextBytes(entity.Salt);
        //        //var data = Encoding.UTF8.GetBytes(session.Password).Concat(entity.Salt).ToArray();

        //        //entity.Password = new SHA512Managed().ComputeHash(data);

        //        context.ExerciseRows.Add(entity);
        //        context.SaveChanges();

        //        return entity.Id;
        //    }

        //}

        
    }
}