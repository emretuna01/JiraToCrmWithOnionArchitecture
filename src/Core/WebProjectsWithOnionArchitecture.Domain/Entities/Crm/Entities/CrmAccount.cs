using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities;

namespace WebProjectsWithOnionArchitecture.Domain.Crm.Entities
{
    public class CrmAccount : BaseEntity
    {
        public string OdataEtag { get; set; }
        public string Name { get; set; }
        public int Statecode { get; set; }
        public Guid Accountid { get; set; }
    }
}
