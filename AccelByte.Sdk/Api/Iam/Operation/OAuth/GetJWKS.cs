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
    /// GetJWKS
    ///
    /// 
    /// 
    /// This endpoint serves public keys for verifying JWT access tokens generated by this service.
    /// 
    /// 
    /// 
    /// 
    /// When a client application wants to verify a JWT token, it needs to get the 'kid' value found in the JWT token header and use it
    /// to look up the corresponding public key from a set returned by this endpoint. The client application can then use that public key to verify the JWT.
    /// 
    /// 
    /// 
    /// 
    /// A client application might cache the keys so it doesn't need to do request every time it needs to verify a JWT token. If a client application
    /// caches the keys and a key with the same 'kid' cannot be found in the cache, it should then try to refresh the keys by making a request to this
    /// endpoint again.
    /// 
    /// 
    /// 
    /// 
    /// Please refer to the RFC for more information about JWK (JSON Web Key): https://tools.ietf.org/html/rfc7517
    /// </summary>
    public class GetJWKS : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetJWKSBuilder Builder = new GetJWKSBuilder();

        public class GetJWKSBuilder
            : OperationBuilder<GetJWKSBuilder>
        {
            internal GetJWKSBuilder() { }






            public GetJWKS Build(
            )
            {
                GetJWKS op = new GetJWKS(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetJWKS(GetJWKSBuilder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetJWKS(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/jwks";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OauthcommonJWKSet? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthcommonJWKSet>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthcommonJWKSet>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}