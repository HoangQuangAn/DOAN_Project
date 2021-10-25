using DOAN_Project.Model;
using System;


namespace DOAN_Project.Data.Infrastructure
{
    public interface IDbFactory:IDisposable
    {
        DOAN_DbContext Init();
    }
}
