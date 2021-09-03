using DOAN_Project.Data.Infrastructure;
using DOAN_Project.Model.Models;

namespace DOAN_Project.Data.Repositories
{
    public interface IProductRepository
    {
    }

    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}