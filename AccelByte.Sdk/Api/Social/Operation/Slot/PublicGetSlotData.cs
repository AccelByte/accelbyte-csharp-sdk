using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicGetSlotData
    ///
    /// Get slot data.
    /// Other detail info:
    /// 
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SLOTDATA", action=2 (READ)
    ///         *  Returns : slot data
    /// </summary>
    public class PublicGetSlotData : AccelByte.Sdk.Core.Operation
    {
        public PublicGetSlotData(
            string namespace_,            
            string slotId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/octet-stream" };

        public override string? Security {get; set;} = "Bearer";
        
        public byte[]? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    return ms.ToArray();
                }
            }
            else if (code == (HttpStatusCode)200)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    payload.CopyTo(ms);
                    return ms.ToArray();
                }
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}