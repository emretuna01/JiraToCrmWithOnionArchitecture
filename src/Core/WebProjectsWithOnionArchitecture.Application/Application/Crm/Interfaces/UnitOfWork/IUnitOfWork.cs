using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        public Task<IDbContextTransaction> BeginTransactionAsync();        
        public ICrmUserRepository CrmUserRepository { get;}
        public ICrmAccountRepository CrmAccountRepository { get; }
        public ICrmTaskRepository CrmTaskRepository { get; }
        public ICrmSalesOrderRepository CrmSalesOrderRepository { get; }

    }
}
