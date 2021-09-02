using DOAN_Project.Data.Repositories;
using DOAN_Project.Model;
using DOAN_Project.Model.Repositories;

namespace DOAN_Project.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private DOAN_DbContext dbContext;

        public DOAN_DbContext Init()
        {
            return dbContext ?? (dbContext = new DOAN_DbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}