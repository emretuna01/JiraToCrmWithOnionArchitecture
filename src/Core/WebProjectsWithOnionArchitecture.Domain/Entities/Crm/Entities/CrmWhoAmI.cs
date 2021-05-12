using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Common;

namespace WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities
{
    public class CrmWhoAmI : BaseEntity
    {
        public string OdataContext { get; set; }
        public string BusinessUnitId { get; set; }
        public string UserId { get; set; }
        public string OrganizationId { get; set; }
    }
}
