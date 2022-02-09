using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    public class PublicUpdateUserNamespaceSlot : AccelByte.Sdk.Core.Operation
    {
        public PublicUpdateUserNamespaceSlot(
            string namespace_,            
            string slotId,            
            string userId,            
            string? label,            
            List<string>? tags,            
            string? checksum,            
            string? customAttribute,            
            Stream? file            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["slotId"] = slotId;
            PathParams["userId"] = userId;
            
            if (label != null) QueryParams["label"] = label;
            if (tags != null) QueryParams["tags"] = tags;
            
            if (checksum != null) FormParams["checksum"] = checksum;
            if (customAttribute != null) FormParams["customAttribute"] = customAttribute;
            if (file != null) FormParams["file"] = file;
            
            CollectionFormatMap["tags"] = "multi";
            
            
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/slots/{slotId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "multipart/form-data" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.SlotInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SlotInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SlotInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}