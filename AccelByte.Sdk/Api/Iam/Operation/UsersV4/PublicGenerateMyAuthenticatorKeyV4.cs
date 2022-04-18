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
    /// PublicGenerateMyAuthenticatorKeyV4
    ///
    /// 
    /// 
    /// This endpoint is used to generate a secret key for 3rd-party authenticator app.
    /// A QR code URI is also returned so that frontend can generate QR code image.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class PublicGenerateMyAuthenticatorKeyV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGenerateMyAuthenticatorKeyV4Builder Builder = new PublicGenerateMyAuthenticatorKeyV4Builder();

        public class PublicGenerateMyAuthenticatorKeyV4Builder
            : OperationBuilder<PublicGenerateMyAuthenticatorKeyV4Builder>
        {
            
            internal PublicGenerateMyAuthenticatorKeyV4Builder() { }





            public PublicGenerateMyAuthenticatorKeyV4 Build(
                string namespace_
            )
            {
                PublicGenerateMyAuthenticatorKeyV4 op = new PublicGenerateMyAuthenticatorKeyV4(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGenerateMyAuthenticatorKeyV4(PublicGenerateMyAuthenticatorKeyV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGenerateMyAuthenticatorKeyV4(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/authenticator/key";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelAuthenticatorKeyResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelAuthenticatorKeyResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelAuthenticatorKeyResponseV4>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}