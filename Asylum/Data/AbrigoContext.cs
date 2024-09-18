using Asylum.Models;
using Microsoft.EntityFrameworkCore;

namespace Asylum.Data
{
    public class AbrigoContext : DbContext
    {
        public AbrigoContext(DbContextOptions<AbrigoContext> options) : base(options) { }

        public DbSet<Paciente> Pacientes { get; set; }
    }
}
