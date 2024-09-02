using Microsoft.EntityFrameworkCore;
using Power_BI_Extension.Models;

namespace Power_BI_Extension.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<PBIDesign> Designs
        {
            get; set;
        }
        public DbSet<Category> categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PBIDesign>().HasData(new PBIDesign
            {
                Id = 1,
                Name = "Penjagaan Asset",
                Description = "Reka bentuk ini menunjukkan prestasi dan data untuk Asset",
                PbiUrl = "https://app.powerbi.com/view?r=eyJrIjoiMjYyOTNmOGMtNjUwZC00MDAwLWE5ODUtYjY1MDI0OGUxMjRlIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D",
                CatId = 1,
                Thumb = "./images/default.jpg"
            });
            modelBuilder.Entity<PBIDesign>().HasData(new PBIDesign
            {
                Id = 2,
                Name = "Data Rangkaian",
                Description = "Reka Bentuk ini menunjukkan Data dan prestasi Data Rangkaian",
                PbiUrl = "https://app.powerbi.com/view?r=eyJrIjoiMmI0YjcyZDUtZjNhYy00MGMxLWEzZDktNTkzZDE5ZDQzZDUxIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D",
                CatId = 2,
                Thumb = "./images/default.jpg"
            });
            modelBuilder.Entity<PBIDesign>().HasData(new PBIDesign
            {
                Id = 3,
                Name = "Road Accident",
                Description = "Reka Bentuk ini menunjukkan Kadar berlakunya kemalangan dan juga kematian",
                PbiUrl = "https://app.powerbi.com/view?r=eyJrIjoiOTc4YmVjMGUtY2M4Ni00YTQwLWJmZTktNGQwM2I1NDE1NTZiIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D",
                CatId = 3,
                Thumb = "./images/default.jpg"
            });


            modelBuilder.Entity<Category>().HasData(new
            {
                Id = 1, 
                Name = "Asset Management"

            });
            modelBuilder.Entity<Category>().HasData(new
            {
                Id = 2,
                Name = "Penyedia Rangkaian"

            });
            modelBuilder.Entity<Category>().HasData(new
            {
                Id = 3,
                Name = "Road Care"

            });

        }
    }
}
