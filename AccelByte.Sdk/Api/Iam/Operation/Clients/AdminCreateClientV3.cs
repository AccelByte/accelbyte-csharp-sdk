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
    /// AdminCreateClientV3
    ///
    /// Add a new OAuth 2.0 client
    /// A new client automatically granted with these scopes: commerce, account, analytics, publishing, social.
    /// 
    /// **Note for Multi Tenant Mode (Confidential Client):**
    /// Only Super admin can set permission with resource & action.
    /// Studio admin & game admin need set permission with permission module.
    /// 
    /// action code: 10301
    /// 
    /// **Fields Description:**
    /// - **clientId** : The client ID. e.g f815e5c44f364993961be3b3f26a7bf4
    /// - **clientName** : The client name. e.g E-commerce
    /// - **secret** : The client's secret. It's empty if the client's type is a public client. Otherwise, the client secret is required
    /// - **namespace** : The namespace where the client lives. e.g sample-game
    /// - **redirectUri** : Contains the redirect URI used in OAuth callback. e.g https://example.net/platform
    /// - **oauthClientType** : The OAuth 2.0 client type. The client type determines whether the authorization needs Proof Of Key Exchange or not.
    /// A public client type doesn't have a client secret and should use PKCE flow.
    /// A confidential client type has a client secret and don't use PKCE flow
    /// Supported oAuthClientType :
    /// - **Public**
    /// - **Confidential**
    /// - **audiences** : List of target client IDs who is intended to receive the token. e.g ["eaaa65618fe24293b00a61454182b435", "40073ee9bc3446d3a051a71b48509a5d"]
    /// - **baseUri** : A base URI of the application. It is used for making sure the token is intended to be used by the client. e.g https://example.net/platform
    /// - **clientPermissions** : Contains the client's permissions
    /// - **deletable** : The flag to identify whether client is deletable (optional). default value: true
    /// - **clientPlatform**: available client platform (optional). default value: ""
    /// - Playstation
    /// - Xbox
    /// - Steam
    /// - Epic
    /// - IOS
    /// - GooglePlay
    /// - Nintendo
    /// - Oculus
    /// - **twoFactorEnabled**: The flag to indicate whether 2FA validation is enable for this client. default value: false
    /// - **oauthAccessTokenExpiration**: a configurable expiration time for **access_token**, default value: 0 (mean fetch value from environment variable)
    /// - **oauthRefreshTokenExpiration**: a configurable expiration time for **refresh_token**, default value: 0 (mean fetch value from environment variable)
    /// - **oauthAccessTokenExpirationTimeUnit**: a configurable expiration time unit for **access_token**, default value: SECONDS
    /// - **oauthRefreshTokenExpirationTimeUnit**: a configurable expiration time unit for **refresh_token**, default value: SECONDS
    /// </summary>
    public class AdminCreateClientV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateClientV3Builder Builder { get => new AdminCreateClientV3Builder(); }

        public class AdminCreateClientV3Builder
            : OperationBuilder<AdminCreateClientV3Builder>
        {





            internal AdminCreateClientV3Builder() { }






            public AdminCreateClientV3 Build(
                ClientmodelClientCreationV3Request body,
                string namespace_
            )
            {
                AdminCreateClientV3 op = new AdminCreateClientV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminCreateClientV3(AdminCreateClientV3Builder builder,
            ClientmodelClientCreationV3Request body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateClientV3(
            string namespace_,
            Model.ClientmodelClientCreationV3Request body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ClientmodelClientV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ClientmodelClientV3Response>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ClientmodelClientV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientV3Response>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}