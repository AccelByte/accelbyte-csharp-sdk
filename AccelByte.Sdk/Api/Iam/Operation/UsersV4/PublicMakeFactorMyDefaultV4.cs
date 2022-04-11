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
    /// PublicMakeFactorMyDefaultV4
    ///
    /// 
    /// 
    /// This endpoint is used to make 2FA factor default.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class PublicMakeFactorMyDefaultV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicMakeFactorMyDefaultV4Builder Builder = new PublicMakeFactorMyDefaultV4Builder();

        public class PublicMakeFactorMyDefaultV4Builder
        {
            
            
            internal PublicMakeFactorMyDefaultV4Builder() { }





            public PublicMakeFactorMyDefaultV4 Build(
                string factor,
                string namespace_
            )
            {
                return new PublicMakeFactorMyDefaultV4(this,
                    factor,                    
                    namespace_                    
                );
            }
        }

        private PublicMakeFactorMyDefaultV4(PublicMakeFactorMyDefaultV4Builder builder,
            string factor,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (factor != null) FormParams["factor"] = factor;
            
            
            
        }
        #endregion

        public PublicMakeFactorMyDefaultV4(
            string namespace_,            
            string factor            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            if (factor != null) FormParams["factor"] = factor;
            
            
            
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/factor";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}