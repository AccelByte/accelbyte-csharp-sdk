using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// reportUser
    ///
    /// This API is for game service to report a game player.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ACTION", action=1 (CREATE)
    /// </summary>
    public class ReportUser : AccelByte.Sdk.Core.Operation
    {
        public ReportUser(
            string namespace_,            
            Model.UserReportRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/report";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if ( code == (HttpStatusCode)422 )
            {
                var payloadString = Helper.ConvertInputStreamToString(payload);
                
                throw new HttpResponseException(code, payloadString);
            }
        }
    }
}