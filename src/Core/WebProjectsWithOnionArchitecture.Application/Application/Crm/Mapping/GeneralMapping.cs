using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Application.Crm.Features.Queries.GetCrmUser;
using WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Mapping
{
    public class GeneralMapping:Profile
    {
        public GeneralMapping()
        {
            CreateMap<CrmUser, InsertCrmUserCommandResponse>().ReverseMap();
            CreateMap<CrmUser, GetCrmUserResponse>().ReverseMap();
        }
        
    }
}
