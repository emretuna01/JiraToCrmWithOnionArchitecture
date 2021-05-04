using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.DbRepository;

namespace WebProjectsWithOnionArchitecture.Application.Crm.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<IDbContextTransaction> BeginTransactionAsync();        
        public ICrmUserRepository CrmUserRepository { get;}
        public ICrmAccountRepository CrmAccountRepository { get; }
        public ICrmTaskRepository CrmTaskRepository { get; }
        public ICrmSalesOrderRepository CrmSalesOrderRepository { get; }

    }
}
