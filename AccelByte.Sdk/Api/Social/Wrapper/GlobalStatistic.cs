using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Api.Social.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Social.Wrapper
{
    public class GlobalStatistic {
        private readonly AccelByteSDK _sdk;

        public GlobalStatistic(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.GlobalStatItemPagingSlicedResult? GetGlobalStatItems(GetGlobalStatItems input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}