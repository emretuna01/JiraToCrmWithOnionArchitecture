using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities
{
    public class CrmWhoAmI
    {
        public string OdataContext { get; set; }
        public string BusinessUnitId { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }
    }
}
