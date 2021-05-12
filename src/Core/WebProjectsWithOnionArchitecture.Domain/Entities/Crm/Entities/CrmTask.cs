using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Common;

namespace WebProjectsWithOnionArchitecture.Domain.Entities.Crm.Entities
{
    public class CrmTask: BaseEntity
    {   
        public string Subject { get; set; }
        public string Description { get; set; }
        public string RegardingObjectidSalesOrderOdataBind { get; set; }
        public DateTimeOffset Scheduledend { get; set; }
        public string categoryOfTask { get; set; }

    }
}
