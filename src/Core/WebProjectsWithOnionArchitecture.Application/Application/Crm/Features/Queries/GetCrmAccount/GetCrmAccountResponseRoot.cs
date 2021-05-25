using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Application.Crm.Features.Queries.GetCrmAccount
{
    public class GetCrmAccountResponseRoot
    {      
        public string OdataContext { get; set; }       
        public List<GetCrmAccountResponse> InsertCrmAccountCommandResponse { get; set; }      
        public string OdataNextLink { get; set; }
    }
}
