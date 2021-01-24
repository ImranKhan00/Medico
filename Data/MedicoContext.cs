using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Medico.Models;

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



        public DbSet<FYP.Models.Cure> Cures { get; set; }

        public DbSet<FYP.Models.Diagnosis> Diagnoses { get; set; }

        public DbSet<FYP.Models.Precaution> Precautions { get; set; }

        public DbSet<FYP.Models.Symptoms> Symptoms { get; set; }

        public DbSet<FYP.Models.User> Users { get; set; }

        public DbSet<FYP.Models.Disease> Diseases { get; set; }

        public DbSet<Medico.Models.DiagnosedDisease> DiagnosedDiseases { get; set; }



    }
}
