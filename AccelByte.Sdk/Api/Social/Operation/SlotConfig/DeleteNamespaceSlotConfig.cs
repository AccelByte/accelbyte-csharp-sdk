using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// deleteNamespaceSlotConfig
    ///
    /// Deletes a namespace slot configuration, the configuration will be default
    /// after delete.
    /// Other detail info:
    /// 
    ///   *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:SLOTCONFIG", action=8 (DELETE)
    /// </summary>
    public class DeleteNamespaceSlotConfig : AccelByte.Sdk.Core.Operation
    {
        public DeleteNamespaceSlotConfig(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/social/admin/namespaces/{namespace}/config";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}