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
    /// AdminCreateClientV3
    ///
    /// Add a new OAuth 2.0 client. Protected by the permission: ADMIN:NAMESPACE:{namespace}:CLIENT [CREATE]
    /// 
    /// A new client automatically granted with these scopes: commerce, account, analytics, publishing, social.
    /// 
    /// action code: 10301
    /// 
    /// 
    /// 
    /// Fields Description:
    /// 
    /// 
    ///           * clientId : The client ID. e.g f815e5c44f364993961be3b3f26a7bf4
    /// 
    /// 
    ///           * clientName : The client name. e.g E-commerce
    /// 
    /// 
    ///           * secret : The client's secret. It's empty if the client's type is a public client. Otherwise, the client secret is required
    /// 
    /// 
    ///           * namespace : The namespace where the client lives. e.g sample-game
    /// 
    /// 
    ///           * redirectUri : Contains the redirect URI used in OAuth callback. e.g https://example.net/platform
    /// 
    /// 
    ///           * oauthClientType : The OAuth 2.0 client type. The client type determines whether the authorization needs Proof Of Key Exchange or not.
    /// A public client type doesn't have a client secret and should use PKCE flow.
    /// A confidential client type has a client secret and don't use PKCE flow
    /// Supported oAuthClientType :
    /// 
    ///             * Public
    /// 
    /// 
    ///             * Confidential
    /// 
    /// 
    ///           * audiences : List of target client IDs who is intended to receive the token. e.g ["eaaa65618fe24293b00a61454182b435", "40073ee9bc3446d3a051a71b48509a5d"]
    /// 
    /// 
    ///           * baseUri : A base URI of the application. It is used for making sure the token is intended to be used by the client. e.g https://example.net/platform
    /// 
    /// 
    ///           * clientPermissions : Contains the client's permissions
    /// </summary>
    public class AdminCreateClientV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminCreateClientV3(
            string namespace_,            
            Model.ClientmodelClientCreationV3Request body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ClientmodelClientV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClientmodelClientV3Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}