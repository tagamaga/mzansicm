using Mzansi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Mzansi.DAL
{
    public class MzansiContext : DbContext
    {
        public MzansiContext() : base("MzansiContext")
        {

        }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<BankBranch> BankBranches { get; set; }
        public DbSet<City> Cities{ get; set; }
        public DbSet<Commission> Commissions { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<mcmUser> mcmUsers { get; set; }
        public DbSet<Region> Regions{ get; set; }
        public DbSet<Town> Towns{ get; set; }
        public DbSet<UserType> UserTypes{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }


    }
}