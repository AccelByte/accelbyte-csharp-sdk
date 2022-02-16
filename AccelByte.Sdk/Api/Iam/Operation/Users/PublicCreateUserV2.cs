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
    /// PublicCreateUserV2
    ///
    /// 
    /// 
    /// 
    /// Available Authentication Types:
    /// 
    /// 
    /// 
    /// 
    ///           1.  EMAILPASSWD : an authentication type used for new user registration through email.
    /// 
    /// 
    /// 
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// </summary>
    public class PublicCreateUserV2 : AccelByte.Sdk.Core.Operation
    {
        public PublicCreateUserV2(
            string namespace_,            
            Model.ModelUserCreateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelUserCreateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserCreateResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}