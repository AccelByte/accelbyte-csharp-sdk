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
    /// PublicUpdateUserV2
    ///
    /// 
    /// 
    /// 
    /// This Endpoint support update user based on given data. Single request can update single field or multi fields.
    /// 
    /// This endpoint require valid user access token to accessed.
    /// 
    /// Supported field {Country, DisplayName, LanguageTag}
    /// </summary>
    public class PublicUpdateUserV2 : AccelByte.Sdk.Core.Operation
    {
        public PublicUpdateUserV2(
            string namespace_,            
            string userId,            
            Model.ModelUserUpdateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelUserResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}