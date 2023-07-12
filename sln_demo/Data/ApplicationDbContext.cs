using Microsoft.EntityFrameworkCore;
using sln_demo.Models;

namespace sln_demo.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {



        }
        public DbSet<Personal> Personal { get; set; }
        public IEnumerable<HistorialVuelos> HistorialVuelos { get; internal set; }
    }
}
