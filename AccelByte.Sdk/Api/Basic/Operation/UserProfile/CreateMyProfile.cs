// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// createMyProfile
    ///
    /// Create my profile.
    ///  Client with user token can create user profile in target namespace
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:PROFILE" , action=1 (CREATE)
    ///   *  Action code : 11401
    ///   *  Returns : Created user profile
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to create publisher user profile
    ///     * can be filled with game namespace in order to create game user profile
    ///   *  Language : allowed format: en, en-US
    ///   *  Country : ISO3166-1 alpha-2 two letter, e.g. US
    ///   * Timezone : IANA time zone, e.g. Asia/Shanghai
    /// </summary>
    public class CreateMyProfile : AccelByte.Sdk.Core.Operation
    {
        public CreateMyProfile(
            string namespace_,            
            Model.UserProfilePrivateCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserProfilePrivateInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}