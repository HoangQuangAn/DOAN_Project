using DOAN_Project.Data.Infrastructure;
using DOAN_Project.Model.Models;
using DOAN_Project.Model.Repositories;

namespace DOAN_Project.Data.Repositories
{
    public interface IOrderRepository
    {
    }

    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}