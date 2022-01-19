using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dslogmanager.Wrapper
{
    public class AllTerminatedServers {
        private readonly AccelByteSDK _sdk;

        public AllTerminatedServers(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public void BatchDownloadServerLogs(BatchDownloadServerLogs input) {
            var response = _sdk.runRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsListTerminatedServersResponse? ListAllTerminatedServers(ListAllTerminatedServers input) {
            var response = _sdk.runRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}