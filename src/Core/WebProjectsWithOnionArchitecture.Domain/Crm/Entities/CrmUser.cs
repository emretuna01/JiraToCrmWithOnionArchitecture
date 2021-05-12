using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Crm.Common;

namespace WebProjectsWithOnionArchitecture.Domain.Crm.Entities
{
    public class CrmUser: BaseCrmEntity
    {
        //TODO:Last login property will be added
        public string UserName { get; set; }
        public string Password { get; set; }        
        public string OdataContext { get; set; }
        public string BusinessUnitId { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }       


    }
}
