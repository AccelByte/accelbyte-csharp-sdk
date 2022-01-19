using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Api.Matchmaking.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Matchmaking.Wrapper
{
    public class SocialMatchmaking {
        private readonly AccelByteSDK _sdk;

        public SocialMatchmaking(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsUpdatePlayerPlaytimeWeightResponse? UpdatePlayTimeWeight(UpdatePlayTimeWeight input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}