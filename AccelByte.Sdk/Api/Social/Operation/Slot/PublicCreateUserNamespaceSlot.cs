using System.Net;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    public class PublicCreateUserNamespaceSlot : AccelByte.Sdk.Core.Operation
    {
        public PublicCreateUserNamespaceSlot(
            string namespace_,            
            string userId,            
            string? label,            
            List<string>? tags,            
            string? checksum,            
            string? customAttribute,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (label != null) QueryParams["label"] = label;
            if (tags != null) QueryParams["tags"] = Convert.ToString(tags)!;
            
            if (checksum != null) FormParams["checksum"] = checksum;
            if (customAttribute != null) FormParams["customAttribute"] = customAttribute;
            if (file != null) FormParams["file"] = Convert.ToString(file)!; // XXX Handle stream
            
            
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}