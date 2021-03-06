using DOAN_Project.Model.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace DOAN_Project.Data
{
    public class DOAN_DbContext : IdentityDbContext<ApplicationUser>
    {
        public DOAN_DbContext() : base("DOAN_Connection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Footer> Footers { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuGroup> MenuGroups{ get; set; }
        public DbSet<Order> Orders{ get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostCategory> PostCategories{ get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories{ get; set; }
        public DbSet<ProductTag> ProductTags{ get; set; }
        public DbSet<Slide> Slides{ get; set; }
        public DbSet<SupportOnline> SupportOnlines{ get; set; }
        public DbSet<SystemConfig> SystemConfigs{ get; set; }
        public DbSet<Tag> Tags{ get; set; }
        public DbSet<VisitorStatistic> VisitorStatistics{ get; set; }
        public DbSet<Error> Errors{ get; set; }

        public static DOAN_DbContext Create()
        {
            return new DOAN_DbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}