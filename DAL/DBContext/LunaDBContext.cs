using Microsoft.EntityFrameworkCore;
using LunaServer.DAL.Entities;

namespace LunaServer.DAL.DBContext
{
    public class LunaDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Queue> Queues { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Pharmacist> Pharmacists { get; set; }
        public DbSet<Pharmacy> Pharmacies { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<ConsultingUnit> ConsultingUnits { get; set; }

        public LunaDBContext(DbContextOptions<LunaDBContext> options):base(options){}

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer("server=DESKTOP-4P6HKDE\\saky; user id=admin; password=admin; database=LunaDev; Pooling=true; Max Pool Size=100; MultipleActiveResultSets=True; Encrypt=False;");
            }
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }

    }

}