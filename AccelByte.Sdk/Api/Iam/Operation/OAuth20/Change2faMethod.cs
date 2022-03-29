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
    /// Change2FAMethod
    ///
    /// Change 2FA method(In Development)
    /// 
    /// 
    /// 
    /// This endpoint is used for change 2FA method. Only enabled methods are accepted.
    /// 
    /// 
    /// 
    /// 
    /// Supported methods:
    /// 
    /// 
    /// 
    /// 
    ///                 * authenticator
    /// 
    /// 
    ///                 * backupCodes
    /// </summary>
    public class Change2faMethod : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static Change2faMethodBuilder Builder = new Change2faMethodBuilder();

        public class Change2faMethodBuilder
        {
            
            
            internal Change2faMethodBuilder() { }





            public Change2faMethod Build(
                string factor,
                string mfaToken
            )
            {
                return new Change2faMethod(this,
                    factor,                    
                    mfaToken                    
                );
            }
        }

        private Change2faMethod(Change2faMethodBuilder builder,
            string factor,
            string mfaToken
        )
        {
            
            
            if (factor != null) FormParams["factor"] = factor;
            if (mfaToken != null) FormParams["mfaToken"] = mfaToken;
            
            
            
        }
        #endregion

        public Change2faMethod(
            string factor,            
            string mfaToken            
        )
        {
            
            
            if (factor != null) FormParams["factor"] = factor;
            if (mfaToken != null) FormParams["mfaToken"] = mfaToken;
            
            
            
        }

        public override string Path => "/iam/v3/oauth/mfa/factor/change";

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