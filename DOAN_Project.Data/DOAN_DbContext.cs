using DOAN_Project.Model.Models;
using System.Data.Entity;

namespace DOAN_Project.Model
{
    public class DOAN_DbContext : DbContext
    {
        public DOAN_DbContext() : base("DOAN_Connection")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Product> Footers { get; set; }
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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure domain classes using modelBuilder here..

        }
    }
}