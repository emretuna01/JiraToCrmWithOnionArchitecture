namespace WebProjectsWithOnionArchitecture.Application.Application.App.Features.Commands.InsertUser
{
    public class InsertUserCommandHandler
    {/*
        readonly ICrmUserRepository _crmUserRepository;
        private CrmUser _crmUser;
        private InsertCrmUserCommandResponse _insertCrmUserCommandResponse;

        public InsertCrmUserCommandHandler(ICrmUserRepository  crmUserRepository,CrmUser crmUser, InsertCrmUserCommandResponse insertCrmUserCommandResponse)
        {
            _crmUserRepository = crmUserRepository;
            _crmUser = crmUser;
            _insertCrmUserCommandResponse = insertCrmUserCommandResponse;
        }

        public async Task<InsertCrmUserCommandResponse> AddToDb(InsertCrmUserCommandRequest insertCrmUserCommandRequest)
        {
            //TODO: automapper library will be added here
            _crmUser.UserName = insertCrmUserCommandRequest.UserName;
            _crmUser.Password = insertCrmUserCommandRequest.Password; 

             var count= await _crmUserRepository.AddAsync(_crmUser);          

            _insertCrmUserCommandResponse.Message = count.ToString() + EnumHolders.ResponseMessages.AddedSuccessfully.ToString();
            _insertCrmUserCommandResponse.IsSuccessfull = count >= 0 ? EnumHolders.ResponseStatus.True.ToString() : EnumHolders.ResponseStatus.False.ToString();

            return _insertCrmUserCommandResponse;
        }
        */
    }
}
