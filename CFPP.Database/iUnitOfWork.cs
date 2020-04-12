using CFPP.Database.iRepositories;
using System;

namespace CFPP.Database
{
    public interface IUnitOfWork : IDisposable
    {
        ICustomerRepository Customers { get; }
        ICaseRepository Cases { get; }
        int Complete();
    }
}
