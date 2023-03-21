using Core.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedAsync(ApplicationDbContext dbContext)
        {
            if (!dbContext.Provinces.Any())
            {
                var provincesData = File.ReadAllText("../Infrastructure/Data/SeedData/province.json");
                var provinces = JsonSerializer.Deserialize<List<Province>>(provincesData);
                dbContext.Provinces.AddRange(provinces);
            }
            if (!dbContext.Counties.Any())
            {
                var countiesData = File.ReadAllText("../Infrastructure/Data/SeedData/county.json");
                var counties = JsonSerializer.Deserialize<List<County>>(countiesData);
                dbContext.Counties.AddRange(counties);
            }
            //if (!dbContext.Publications.Any())
            //{
            //    var publicationsData = File.ReadAllText("../Infrastructure/Data/SeedData/publi.json");
            //    var publications = JsonSerializer.Deserialize<List<Publication>>(publicationsData);
            //    dbContext.Publications.AddRange(publications);
            //}

            if (dbContext.ChangeTracker.HasChanges()) await dbContext.SaveChangesAsync();
        }
    }
}
