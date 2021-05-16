using System.Threading.Tasks;
using WebProjectsWithOnionArchitecture.Application.Application.App.Features.Enums;
using WebProjectsWithOnionArchitecture.Application.Application.App.Interfaces.DbRepository;
using WebProjectsWithOnionArchitecture.Domain.Entities.App.Entities;

namespace WebProjectsWithOnionArchitecture.Application.Application.App.Features.Commands.InsertUser
{
    public class InsertUserCommandHandler
    {
        private readonly IUserRepository _userRepository;
        private User _user;
        private InsertUserCommandResponse _insertUserCommandResponse;

        public InsertUserCommandHandler(IUserRepository userRepository, User user, InsertUserCommandResponse insertUserCommandResponse)
        {
            _userRepository = userRepository;
            _user = user;
            _insertUserCommandResponse = insertUserCommandResponse;
        }

        public async Task<InsertUserCommandResponse> InsertUserToDb(InsertUserCommandRequest insertUserCommandRequest)
        { 
            //TODO: automapper library will be added here
            _user.UserName = insertUserCommandRequest.UserName;
            _user.Password = insertUserCommandRequest.Password;

            var count = await _userRepository.AddAsync(_user);
        
            _insertUserCommandResponse.Message = count.ToString() + EnumHolders.ResponseMessages.Added.ToString();
            _insertUserCommandResponse.IsSuccessfull = count >= 0 ? EnumHolders.ResponseStatus.True.ToString() : EnumHolders.ResponseStatus.False.ToString();

            return _insertUserCommandResponse;
        }
    }
}
