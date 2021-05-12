using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Interfaces.DbRepository
{
    public interface ICrmTaskRepository : IDbRepository<CrmTask>
    {
    }
}
