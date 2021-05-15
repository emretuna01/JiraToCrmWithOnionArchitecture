using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.Queries;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Features.Commands.InsertUser
{
    public class InsertUserCommandRequest : IRequestQuery
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
