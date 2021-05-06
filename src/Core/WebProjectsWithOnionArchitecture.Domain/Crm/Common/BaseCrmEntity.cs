using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Domain.Crm.Common
{

    public class BaseCrmEntity
    {
        [Key]
        public Guid Guid { get; set; }

    }
}
