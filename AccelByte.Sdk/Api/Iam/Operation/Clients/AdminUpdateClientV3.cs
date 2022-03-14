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
    /// AdminUpdateClientV3
    ///
    /// Updates an OAuth 2.0 client. Protected by the permission: ADMIN:NAMESPACE:{namespace}:CLIENT [UPDATE].
    /// Specify only the fields you want to update in the request payload, e.g. {"ClientName":"E-commerce", "BaseUri":"https://example.net"}
    /// 
    /// action code: 10302
    /// 
    /// 
    /// 
    /// Fields Description:
    /// 
    /// 
    ///           * clientName : The client name. It should not be empty if the field exists in the body. e.g E-commerce
    /// 
    /// 
    ///           * namespace : The namespace where the client lives. e.g sample-game
    /// 
    /// 
    ///           * redirectUri : Contains the redirect URI used in OAuth callback. It should not be empty if the field exists in the body. e.g https://example.net/platform
    /// 
    /// 
    ///           * audiences : List of target client IDs who is intended to receive the token. e.g ["eaaa65618fe24293b00a61454182b435", "40073ee9bc3446d3a051a71b48509a5d"]
    /// 
    /// 
    ///           * baseUri : A base URI of the application. It is used in the audience checking for making sure the token is used by the right resource server. Required if the application type is a server. e.g https://example.net/platform
    /// 
    /// 
    ///           * clientPermissions : Contains the client's permissions
    /// 
    /// 
    ///           * deletable : The flag to identify whether client is deletable (optional). e.g. true
    /// </summary>
    public class AdminUpdateClientV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateClientV3Builder Builder = new AdminUpdateClientV3Builder();

        public class AdminUpdateClientV3Builder
        {
            
            
            
            internal AdminUpdateClientV3Builder() { }





            public AdminUpdateClientV3 Build(
                ClientmodelClientUpdateV3Request body,
                string clientId,
                string namespace_
            )
            {
                return new AdminUpdateClientV3(this,
                    body,                    
                    clientId,                    
                    namespace_                    
                );
            }
        }

        private AdminUpdateClientV3(AdminUpdateClientV3Builder builder,
            ClientmodelClientUpdateV3Request body,
            string clientId,
            string namespace_
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminUpdateClientV3(
            string clientId,            
            string namespace_,            
            Model.ClientmodelClientUpdateV3Request body            
        )
        {
            PathParams["clientId"] = clientId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/clients/{clientId}";

        public override HttpMethod Method => HttpMethod.Patch;

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