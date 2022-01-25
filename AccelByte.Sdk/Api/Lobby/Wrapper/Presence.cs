using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Presence {
        private readonly AccelByteSDK _sdk;

        public Presence(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.HandlersGetUsersPresenceResponse? UsersPresenceHandlerV1(UsersPresenceHandlerV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}