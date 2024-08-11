using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Core.Types;
using TrainOrgApi.Abstraction;
using TrainOrgApi.Data;
using TrainOrgApi.Dtos;
using TrainOrgApi.Models;
using static System.Collections.Specialized.BitVector32;

namespace TrainOrgApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class SessionsController : ControllerBase
    {
        //private readonly SessionContext _context;

        private readonly ISessionRepository _repository;

        public SessionsController(ISessionRepository repository)
        {
            //_context = context;
            _repository = repository;
        }

        // GET: api/Sessions
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Session>>> GetSession()
        //{
        //    return await _context.Session.ToListAsync();
        //}

        //// GET: api/Sessions/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Session>> GetSession(int id)
        //{
        //    var session = await _context.Session.FindAsync(id);

        //    if (session == null)
        //    {
        //        return NotFound();
        //    }

        //    return session;
        //}

        //// PUT: api/Sessions/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSession(int id, Session session)
        //{
        //    if (id != session.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(session).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SessionExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Sessions
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Session>> PostSession(Session session)
        //{
        //    _context.Session.Add(session);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetSession", new { id = session.Id }, session);
        //}

        [HttpPost("add_session")]
        public ActionResult<int> AddSession(SessionDto session)
        {
            //_context.Session.Add(session);
            try
            {
                return Ok(_repository.AddSession(session));
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }

        [HttpGet("get_all_sessions")]
        public async Task<ActionResult<IEnumerable<Session>>> GetSession()
        {
            try
            {
                return Ok(_repository.GetAllSessions());
            }
            catch (Exception ex)
            {
                return StatusCode(409, ex.Message);
            }
        }
        // DELETE: api/Sessions/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSession(int id)
        //{
        //    var session = await _context.Session.FindAsync(id);
        //    if (session == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Session.Remove(session);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool SessionExists(int id)
        //{
        //    return _context.Session.Any(e => e.Id == id);
        //}
    }
}
