﻿

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=Teeradet;Database=TestVilla01;Trusted_Connection=True;MultipleActiveResultSets=true;TrustServerCertificate=True");
        }

        public DbSet<Villa> Villas { get; set; }
    }
}
