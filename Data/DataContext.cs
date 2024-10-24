using Microsoft.EntityFrameworkCore;

namespace Meta_Ads_World.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserMst> UserMsts { get; set; }
        public DbSet<BrandRegistrationMst> BrandRegistrationMst { get; set; }
        public DbSet<BrandCategoryMst> BrandCategoryMst { get;set; }
    }
}
