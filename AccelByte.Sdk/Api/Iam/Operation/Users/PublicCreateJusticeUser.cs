// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicCreateJusticeUser
    ///
    /// Create Justice User from Publisher User information. It will check first if Justice User on target namespace already exist.
    /// </summary>
    public class PublicCreateJusticeUser : AccelByte.Sdk.Core.Operation
    {
        public PublicCreateJusticeUser(
            string namespace_,            
            string targetNamespace            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["targetNamespace"] = targetNamespace;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/justice/{targetNamespace}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelCreateJusticeUserResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelCreateJusticeUserResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelCreateJusticeUserResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}