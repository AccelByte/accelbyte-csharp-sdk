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
    /// VerifyTokenV3
    ///
    /// This endpoint requires all requests to have Authorization header set with Basic access authentication constructed from client id and client secret.
    /// </summary>
    public class VerifyTokenV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static VerifyTokenV3Builder Builder { get => new VerifyTokenV3Builder(); }

        public class VerifyTokenV3Builder
            : OperationBuilder<VerifyTokenV3Builder>
        {





            internal VerifyTokenV3Builder() { }






            public VerifyTokenV3 Build(
                string token
            )
            {
                VerifyTokenV3 op = new VerifyTokenV3(this,
                    token
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private VerifyTokenV3(VerifyTokenV3Builder builder,
            string token
        )
        {


            if (token is not null) FormParams["token"] = token;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public VerifyTokenV3(
            string token
        )
        {


            if (token is not null) FormParams["token"] = token;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v3/oauth/verify";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Basic";

        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}