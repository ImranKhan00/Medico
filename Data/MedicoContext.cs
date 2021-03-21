using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Medico.Data
{
    public class MedicoContext : IdentityDbContext<IdentityUser>
    {
        public MedicoContext(DbContextOptions<MedicoContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }



        public DbSet<Medico.Models.Cure> Cures { get; set; }

        public DbSet<Medico.Models.Diagnosis> Diagnoses { get; set; }

        public DbSet<Medico.Models.Precaution> Precautions { get; set; }

        public DbSet<Medico.Models.Symptoms> Symptoms { get; set; }

        public new DbSet<Medico.Models.User> Users { get; set; }

        public DbSet<Medico.Models.Disease> Diseases { get; set; }

        public DbSet<Medico.Models.DiagnosedDisease> DiagnosedDiseases { get; set; }
        
        public DbSet<Medico.Models.cSymptomQuestion> SymptomQuestions { get; set; }



    }
}
