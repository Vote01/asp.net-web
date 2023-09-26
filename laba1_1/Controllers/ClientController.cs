using laba1_1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace laba1_1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly PsychologistDBContext _context;

        public ClientController(PsychologistDBContext context)
        {
            _context = context;
        }
       

        [HttpGet]
        public IEnumerable<Client> Get()
        {
            return _context.Client.ToList();
        }

    }
}
