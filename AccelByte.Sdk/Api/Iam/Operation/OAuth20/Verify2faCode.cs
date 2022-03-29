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
    /// Verify2FACode
    ///
    /// Verify 2FA code(In Development)
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
        {
            
            
            
            
            internal Verify2faCodeBuilder() { }





            public Verify2faCode Build(
                string code,
                string factor,
                string mfaToken,
                bool rememberDevice
            )
            {
                return new Verify2faCode(this,
                    code,                    
                    factor,                    
                    mfaToken,                    
                    rememberDevice                    
                );
            }
        }

        private Verify2faCode(Verify2faCodeBuilder builder,
            string code,
            string factor,
            string mfaToken,
            bool rememberDevice
        )
        {
            
            
            if (code != null) FormParams["code"] = code;
            if (factor != null) FormParams["factor"] = factor;
            if (mfaToken != null) FormParams["mfaToken"] = mfaToken;
            FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;
            
            
            
        }
        #endregion

        public Verify2faCode(
            string code,            
            string factor,            
            string mfaToken,            
            bool rememberDevice            
        )
        {
            
            
            if (code != null) FormParams["code"] = code;
            if (factor != null) FormParams["factor"] = factor;
            if (mfaToken != null) FormParams["mfaToken"] = mfaToken;
            FormParams["rememberDevice"] = Convert.ToString(rememberDevice)!;
            
            
            
        }

        public override string Path => "/iam/v3/oauth/mfa/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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