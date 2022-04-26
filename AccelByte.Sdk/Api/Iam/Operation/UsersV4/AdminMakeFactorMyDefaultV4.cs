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
    /// AdminMakeFactorMyDefaultV4
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
    public class AdminMakeFactorMyDefaultV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminMakeFactorMyDefaultV4Builder Builder = new AdminMakeFactorMyDefaultV4Builder();

        public class AdminMakeFactorMyDefaultV4Builder
            : OperationBuilder<AdminMakeFactorMyDefaultV4Builder>
        {
            
            internal AdminMakeFactorMyDefaultV4Builder() { }






            public AdminMakeFactorMyDefaultV4 Build(
                string factor
            )
            {
                AdminMakeFactorMyDefaultV4 op = new AdminMakeFactorMyDefaultV4(this,
                    factor                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminMakeFactorMyDefaultV4(AdminMakeFactorMyDefaultV4Builder builder,
            string factor
        )
        {
            
            
            if (factor != null) FormParams["factor"] = factor;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminMakeFactorMyDefaultV4(
            string factor            
        )
        {
            
            
            if (factor != null) FormParams["factor"] = factor;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/factor";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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