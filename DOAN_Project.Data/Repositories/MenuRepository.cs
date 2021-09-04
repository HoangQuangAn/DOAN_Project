using DOAN_Project.Data.Infrastructure;
using DOAN_Project.Model.Models;
using DOAN_Project.Model.Repositories;

namespace DOAN_Project.Data.Repositories
{
    public interface IMenuRepository : IRepository<Menu>
    {
    }

    public class MenuRepository : RepositoryBase<Menu>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}