using Microsoft.EntityFrameworkCore;
using PortfolioProject.APILayer.DataAccess.Entity;

namespace PortfolioProject.APILayer.DataAccess.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUNA\\SQLEXPRESS;database=AspNetCore5PortfolioAPI;integrated security=true;");
        }

        public DbSet<Category> Categories { get; set; }
    }
}
