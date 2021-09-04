using DOAN_Project.Data.Infrastructure;
using DOAN_Project.Model.Models;
using DOAN_Project.Model.Repositories;

namespace DOAN_Project.Data.Repositories
{
    public interface ISlideRepository : IRepository<Slide>
    {
    }

    public class SlideRepository : RepositoryBase<Slide>, ISlideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}