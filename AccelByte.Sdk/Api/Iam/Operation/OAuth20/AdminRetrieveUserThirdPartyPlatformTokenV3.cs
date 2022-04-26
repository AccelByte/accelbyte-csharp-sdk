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
    /// AdminRetrieveUserThirdPartyPlatformTokenV3
    ///
    /// Admin Retrieve User Third Party Platform Token
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
    /// Notes:
    /// 
    /// 
    /// 
    /// 
    ///                 * Required permission: ADMIN:NAMESPACE:{namespace}:USER:{userId} [READ]
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
    ///                 * xbox live
    /// 
    /// 
    ///                 * steam
    /// </summary>
    public class AdminRetrieveUserThirdPartyPlatformTokenV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRetrieveUserThirdPartyPlatformTokenV3Builder Builder = new AdminRetrieveUserThirdPartyPlatformTokenV3Builder();

        public class AdminRetrieveUserThirdPartyPlatformTokenV3Builder
            : OperationBuilder<AdminRetrieveUserThirdPartyPlatformTokenV3Builder>
        {
            
            
            
            internal AdminRetrieveUserThirdPartyPlatformTokenV3Builder() { }






            public AdminRetrieveUserThirdPartyPlatformTokenV3 Build(
                string namespace_,
                string platformId,
                string userId
            )
            {
                AdminRetrieveUserThirdPartyPlatformTokenV3 op = new AdminRetrieveUserThirdPartyPlatformTokenV3(this,
                    namespace_,                    
                    platformId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminRetrieveUserThirdPartyPlatformTokenV3(AdminRetrieveUserThirdPartyPlatformTokenV3Builder builder,
            string namespace_,
            string platformId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRetrieveUserThirdPartyPlatformTokenV3(
            string namespace_,            
            string platformId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/admin/namespaces/{namespace}/users/{userId}/platforms/{platformId}/platformToken";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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