using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Crm.Common;

namespace WebProjectsWithOnionArchitecture.Domain.Crm.Entities
{
    public class CrmTask: BaseCrmEntity
    {
    
        public string Subject { get; set; }
        public string Description { get; set; }
        public string RegardingObjectidSalesOrderOdataBind { get; set; }
        public DateTimeOffset Scheduledend { get; set; }
        public string categoryOfTask { get; set; }


    }
}
