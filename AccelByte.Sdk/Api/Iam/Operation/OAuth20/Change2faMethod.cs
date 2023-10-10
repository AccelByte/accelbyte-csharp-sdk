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
    /// Change2FAMethod
    ///
    /// Change 2FA method
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
    ///               * authenticator
    /// 
    /// 
    ///               * backupCode
    /// 
    /// 
    ///               * email
    /// </summary>
    public class Change2faMethod : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static Change2faMethodBuilder Builder { get => new Change2faMethodBuilder(); }

        public class Change2faMethodBuilder
            : OperationBuilder<Change2faMethodBuilder>
        {





            internal Change2faMethodBuilder() { }






            public Change2faMethod Build(
                string factor,
                string mfaToken
            )
            {
                Change2faMethod op = new Change2faMethod(this,
                    factor,
                    mfaToken
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private Change2faMethod(Change2faMethodBuilder builder,
            string factor,
            string mfaToken
        )
        {


            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public Change2faMethod(
            string factor,
            string mfaToken
        )
        {


            if (factor is not null) FormParams["factor"] = factor;
            if (mfaToken is not null) FormParams["mfaToken"] = mfaToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/oauth/mfa/factor/change";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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