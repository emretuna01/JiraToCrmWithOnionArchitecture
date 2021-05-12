using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities
{
    public class User: BaseEntity
    {
        //TODO:Last login property will be added
        public string UserName { get; set; }
        public string Password { get; set; }        
        public DateTime LastLogin { get; set; }
        public bool IsActive { get; set; }

    }
}
