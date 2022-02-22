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
    /// RetrieveUserThirdPartyPlatformTokenV3
    ///
    /// Retrieve User Third Party Platform Token
    /// 
    /// 
    /// 
    /// 
    /// This endpoint used for retrieving third party platform token for user that login using third party.
    /// Passing platform group name or it's member will return same access token that can be used across the platform members.
    /// 
    /// 
    /// 
    /// 
    /// 
    /// The third party platform and platform group covered for this is:
    /// 
    /// 
    /// 
    /// 
    ///                 * (psn) ps4web
    /// 
    /// 
    ///                 * (psn) ps4
    /// 
    /// 
    ///                 * (psn) ps5
    /// 
    /// 
    ///                 * epicgames
    /// 
    /// 
    ///                 * twitch
    /// 
    /// 
    ///                 * awscognito
    /// </summary>
    public class RetrieveUserThirdPartyPlatformTokenV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveUserThirdPartyPlatformTokenV3Builder Builder = new RetrieveUserThirdPartyPlatformTokenV3Builder();

        public class RetrieveUserThirdPartyPlatformTokenV3Builder
        {
            
            
            
            internal RetrieveUserThirdPartyPlatformTokenV3Builder() { }





            public RetrieveUserThirdPartyPlatformTokenV3 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                return new RetrieveUserThirdPartyPlatformTokenV3(this,
                    namespace_,                    
                    platformId,                    
                    userId                    
                );
            }
        }

        private RetrieveUserThirdPartyPlatformTokenV3(RetrieveUserThirdPartyPlatformTokenV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public RetrieveUserThirdPartyPlatformTokenV3(
            string namespace_,            
            string platformId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/oauth/namespaces/{namespace}/users/{userId}/platforms/{platformId}/platformToken";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OauthmodelTokenThirdPartyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenThirdPartyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenThirdPartyResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}