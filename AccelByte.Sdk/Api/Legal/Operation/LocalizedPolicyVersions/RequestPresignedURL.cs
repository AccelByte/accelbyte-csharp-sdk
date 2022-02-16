// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// requestPresignedURL
    ///
    /// Request presigned URL for upload attachment for a particular localized version of base policy.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=1 (CREATE)
    /// </summary>
    public class RequestPresignedURL : AccelByte.Sdk.Core.Operation
    {
        public RequestPresignedURL(
            string localizedPolicyVersionId,            
            Model.UploadPolicyVersionAttachmentRequest body            
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/agreement/admin/localized-policy-versions/{localizedPolicyVersionId}/attachments";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UploadLocalizedPolicyVersionAttachmentResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UploadLocalizedPolicyVersionAttachmentResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UploadLocalizedPolicyVersionAttachmentResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}