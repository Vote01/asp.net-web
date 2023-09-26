using laba1_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace laba1_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SessionController : ControllerBase
    {
        private readonly PsychologistDBContext _context;

        public SessionController(PsychologistDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Session> Get()
        {
            return _context.Session.ToList();
        }
    }
}
