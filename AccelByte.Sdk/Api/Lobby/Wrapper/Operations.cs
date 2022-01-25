using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Api.Lobby.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Lobby.Wrapper
{
    public class Operations {
        private readonly AccelByteSDK _sdk;

        public Operations(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsPartyData? AdminUpdatePartyAttributesV1(AdminUpdatePartyAttributesV1 input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public List<Model.LogAppMessageDeclaration>? PublicGetMessages(PublicGetMessages input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}