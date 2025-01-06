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
        public DbSet<BrandCategoryMst> BrandCategoryMst { get; set; }
        public DbSet<InstaPostMst> InstaPostMsts { get; set; }
        public DbSet<InstaPostBudgetMst> InstaPostBudgetMst { get; set; }
        public DbSet<YouTubePostMst> YouTubePostMst { get; set; }
        public DbSet<YouTubePostBudgetMst> youTubePostBudgetMsts { get; set; }
        public DbSet<StateMst> StateMsts { get; set; }
        public DbSet<CityMst> CityMsts { get; set; }
        public DbSet<AreaMst> AreaMsts { get; set; }
        public DbSet<QrCodeMst> QrMst { get; set; }
        public DbSet<BrandPaymentTransactionMst> BrandPaymentTransactionMsts { get; set; }
        public DbSet<UserInstaPostHandlerMst> UserInstaPostHandlerMsts { get; set; }
    }
}
