using DOAN_Project.Data.Infrastructure;
using DOAN_Project.Model.Models;
using DOAN_Project.Model.Repositories;

namespace DOAN_Project.Data.Repositories
{
    public interface IFooterRepository:IRepository<Product>
    {
    }
    public class FooterRepository : RepositoryBase<Product>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}