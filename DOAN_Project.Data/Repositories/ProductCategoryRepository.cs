using DOAN_Project.Data.Infrastructure;
using DOAN_Project.Model.Models;
using DOAN_Project.Model.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DOAN_Project.Data.Repositories
{
    public interface IProductCategoryRepository : IRepository<ProductCategory>
    {
        IEnumerable<ProductCategory> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<ProductCategory>, IProductCategoryRepository
    {
        public ProductCategoryRepository(DbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<ProductCategory> GetByAlias(string alias)
        {
            return DbContext.ProductCategories.Where(x => x.Alias == alias);
        }
    }
}   