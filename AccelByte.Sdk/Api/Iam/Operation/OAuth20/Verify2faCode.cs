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
    /// Verify2FACode
    ///
    /// Verify 2FA code
    /// 
    /// 
    /// 
    /// This endpoint is used for verifying 2FA code.
    /// </summary>
    public class Verify2faCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static Verify2faCodeBuilder Builder = new Verify2faCodeBuilder();

        public class Verify2faCodeBuilder
            : OperationBuilder<Verify2faCodeBuilder>
        {





            internal Verify2faCodeBuilder() { }






            public Verify2faCode Build(
                string code,
                string factor,
                string mfaToken,
                bool rememberDevice
            )
            {
                Verify2faCode op = new Verify2faCode(this,
                    code,                    
                    factor,                    
                    mfaToken,                    
                    rememberDevice                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private Verify2faCode(Verify2faCodeBuilder builder,
            string code,
            string factor,
            string mfaToken,
            bool rememberDevice
        )
        {
            
            
            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;
            FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Verify2faCode(
            string code,            
            string factor,            
            string mfaToken,            
            bool rememberDevice            
        )
        {
            
            
            if (code is not null) FormParams["code"] = code;
            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;
            FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/mfa/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}