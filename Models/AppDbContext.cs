using System.Data.Entity;

namespace ProjekatPsa.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("AppDb")
        {
        }

        public DbSet<Kandidat> Kandidati { get; set; }
        public DbSet<StudijskiProgram> StudijskiProgrami { get; set; }
        public DbSet<PrijavaUpis> Prijave { get; set; }
    }
}
