using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using PhysicianReferralsWeb.Models;

namespace PhysicianReferralsWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Referral> Referrals { get; set; }
        public DbSet<Physician> Physicians { get; set; }
    }
}