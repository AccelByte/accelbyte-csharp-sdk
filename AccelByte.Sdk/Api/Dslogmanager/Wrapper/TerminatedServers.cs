using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Api.Dslogmanager.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Dslogmanager.Wrapper
{
    public class TerminatedServers {
        private readonly AccelByteSDK _sdk;

        public TerminatedServers(AccelByteSDK sdk){
            _sdk = sdk;
        }
        
        public Model.ModelsListTerminatedServersResponse? ListTerminatedServers(ListTerminatedServers input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public void DownloadServerLogs(DownloadServerLogs input) {
            var response = _sdk.RunRequest(input);

            input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
        public Model.ModelsLogFileStatus? CheckServerLogs(CheckServerLogs input) {
            var response = _sdk.RunRequest(input);

            return input.ParseResponse(
                    response.Code, 
                    response.ContentType,
                    response.Payload);
        }
    }
}