using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Queries.GetUserByName;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmAccount;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Commands.InsertCrmUser;
using WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmAccount;
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
            CreateMap<CrmAccountRoot, InsertCrmAccountCommandResponseRoot>().ReverseMap();
            CreateMap<GetCrmAccountRequest, GetUserByNameRequest>().ReverseMap();
            CreateMap<CrmAccountRoot, InsertCrmAccountCommandResponseRoot>().ForMember(destinationMember => destinationMember.InsertCrmAccountCommandResponse ,opearation => opearation.MapFrom( z => z.CrmAccountList ));
            

        }
        
    }
}
