using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.Queries
{
    public interface IRequestQuery
    {
         string UserName { get; set; }
         string Password { get; set; }
    }
}
