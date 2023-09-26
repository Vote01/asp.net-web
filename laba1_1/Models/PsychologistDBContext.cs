using Microsoft.EntityFrameworkCore;

namespace laba1_1.Models
{
    public class PsychologistDBContext : DbContext
    {

        public DbSet<Psychologist> Psychologist { get; set; }
        public DbSet<Specialization> Specialization { get; set; }
        public DbSet<Methods> Methods { get; set; }
        public DbSet<Session> Session { get; set; }
        public DbSet<Client> Client { get; set; }

        public PsychologistDBContext(DbContextOptions<PsychologistDBContext> options) : base(options)
        { }

    }


}
