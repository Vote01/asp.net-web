using laba1_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace laba1_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PsychologistController : ControllerBase
    {
        private readonly PsychologistDBContext _context;
        public PsychologistController(PsychologistDBContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IEnumerable<Psychologist> Get()
        {
            return _context.Psychologist.ToList();
        }

    }
}
