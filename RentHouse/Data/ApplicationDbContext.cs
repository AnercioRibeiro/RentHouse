using Microsoft.EntityFrameworkCore;
using RentHouseAPI.Models;
using RentHouseAPI.Specification;

namespace RentHouseAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<RealState> RealStates { get; set; }
        public DbSet<Province> Provinces { get; set; }
        public DbSet<County> Counties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Tenant>().HasData(
                new Tenant
                {
                    Id = 1,
                    Name = "Adão Garcia",
                    Email = "adao.garcia@outlook.com",
                    Telephone = "000-333-444",
                    Password = "Admin234",
                    CreatedDate = DateTime.Now,

                },
                new Province
                {
                    Id = 1,
                    Name = "Luanda"
                },
                new County
                {
                    Id = 1,
                    Name = "Kilamba kiaxi"
                },
                new Owner
                {
                    Id = 1,
                    Name = "Augusto Kimbamba",
                    Email = "augusto.kimbamba@email.co.ao",
                    Telephone = "889-333-345",
                    Address = "Praça da madeira, Gamek",
                    Password = "augusto233",
                    CreatedDate = DateTime.Now,
                },
                new Publication
                {
                    Id = 1,
                    Identifier = "12333",
                    Address = "Maianga, por traz do supermecado",
                    Description = "Apartamento T3",
                    Tipology = "T2",
                    CreatedDate = DateTime.Now,
                    Details = "",
                    Elevator = true,
                    Division = "",
                    Floor = "Rés do chão",
                    Latitude = "-8.83202967410062",
                    Longitude = "13.27374026209612",
                    Price = 400000,
                    

                }

                );
        }

    }
}
