using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using ST10298613_ContractMonthlyClaimSystem.Models;
using Claim = ST10298613_ContractMonthlyClaimSystem.Models.Claim;
using System.Reflection.Emit;

namespace ST10298613_ContractMonthlyClaimSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<Lecturer> Lecturers { get; set; }
        public DbSet<Claim> Claims { get; set; }
        public DbSet<Approval> Approvals { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Configure relationships
            
                   

           builder.Entity<Claim>()
            .Property(c => c.HourlyRate)
            .HasColumnType("decimal(18, 2)");

            builder.Entity<Claim>()
        .Property(c => c.Id)
        .ValueGeneratedOnAdd(); // Auto-generate Claim ID

            base.OnModelCreating(builder);
        }

    }
}
