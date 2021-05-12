using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities;

namespace WebProjectsWithOnionArchitecture.Domain.Crm.Entities
{
    public class CrmUser: BaseEntity
    {
        public string OdataContext { get; set; }
        public string BusinessUnitId { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }       

    }
}
