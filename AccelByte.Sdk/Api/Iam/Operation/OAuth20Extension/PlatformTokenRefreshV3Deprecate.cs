// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PlatformTokenRefreshV3Deprecate
    ///
    /// 
    /// 
    /// This endpoint will validate the third party platform token, for some platforms will also refresh the token stored in IAM, it will not generate any event or AB access/refresh token.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint can be used by game client to refresh third party token if game client got platform token not found error, for example got 404
    /// platform token not found from IAP/DLC.
    /// 
    /// 
    /// 
    /// 
    /// ## Platforms will refresh stored token:
    /// 
    /// 
    /// 
    /// 
    ///                           * twitch : The platform_tokenâs value is the authorization code returned by Twitch OAuth.
    /// 
    /// 
    ///                           * epicgames : The platform_tokenâs value is an access-token or authorization code obtained from Epicgames EOS Account Service.
    /// 
    /// 
    ///                           * ps4 : The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// 
    /// 
    ///                           * ps5 : The platform_tokenâs value is the authorization code returned by Sony OAuth.
    /// 
    /// 
    ///                           * amazon : The platform_tokenâs value is authorization code.
    /// 
    /// 
    ///                           * awscognito : The platform_tokenâs value is the aws cognito access token or id token (JWT).
    /// 
    /// 
    ///                           * live : The platform_tokenâs value is xbox XSTS token
    /// 
    /// 
    ///                           * snapchat : The platform_tokenâs value is the authorization code returned by Snapchat OAuth.
    /// 
    /// 
    /// 
    ///                           * for specific generic oauth (OIDC) : The platform_tokenâs value should be the same type as created OIDC auth type whether it is auth code, idToken or bearerToken.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PlatformTokenRefreshV3Deprecate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PlatformTokenRefreshV3DeprecateBuilder Builder { get => new PlatformTokenRefreshV3DeprecateBuilder(); }

        public class PlatformTokenRefreshV3DeprecateBuilder
            : OperationBuilder<PlatformTokenRefreshV3DeprecateBuilder>
        {





            internal PlatformTokenRefreshV3DeprecateBuilder() { }






            public PlatformTokenRefreshV3Deprecate Build(
                string platformToken,
                string platformId
            )
            {
                PlatformTokenRefreshV3Deprecate op = new PlatformTokenRefreshV3Deprecate(this,
                    platformToken,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PlatformTokenRefreshV3Deprecate(PlatformTokenRefreshV3DeprecateBuilder builder,
            string platformToken,
            string platformId
        )
        {
            PathParams["platformId"] = platformId;


            if (platformToken is not null) FormParams["platform_token"] = platformToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PlatformTokenRefreshV3Deprecate(
            string platformId,
            string platformToken
        )
        {
            PathParams["platformId"] = platformId;


            if (platformToken is not null) FormParams["platform_token"] = platformToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/v3/platforms/{platformId}/token/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.OauthmodelPlatformTokenRefreshResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.OauthmodelPlatformTokenRefreshResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.OauthmodelPlatformTokenRefreshResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelPlatformTokenRefreshResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}