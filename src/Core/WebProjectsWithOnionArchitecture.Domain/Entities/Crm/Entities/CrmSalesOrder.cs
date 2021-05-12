using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Domain.Entities;

namespace WebProjectsWithOnionArchitecture.Domain.Crm.Entities
{
    public class CrmSalesOrder: BaseEntity
    {        
        public string OdataEtag { get; set; }        
        public string Name { get; set; }        
        public Guid NewLikiliidValue { get; set; }        
        public int Statecode { get; set; }       
        public Guid Salesorderid { get; set; }     
        public DateTimeOffset new_garanti_bitis_tarihi { get; set; }
    }
}
