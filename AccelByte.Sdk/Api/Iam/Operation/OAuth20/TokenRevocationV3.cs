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
    /// TokenRevocationV3
    ///
    /// This endpoint revokes a token.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint requires authorized requests header with Basic Authentication from client that establish the token.
    /// 
    /// 
    /// action code: 10706
    /// </summary>
    public class TokenRevocationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TokenRevocationV3Builder Builder { get => new TokenRevocationV3Builder(); }

        public class TokenRevocationV3Builder
            : OperationBuilder<TokenRevocationV3Builder>
        {





            internal TokenRevocationV3Builder() { }






            public TokenRevocationV3 Build(
                string token
            )
            {
                TokenRevocationV3 op = new TokenRevocationV3(this,
                    token
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private TokenRevocationV3(TokenRevocationV3Builder builder,
            string token
        )
        {


            if (token is not null) FormParams["token"] = token;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public TokenRevocationV3(
            string token
        )
        {


            if (token is not null) FormParams["token"] = token;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/oauth/revoke";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Basic";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}