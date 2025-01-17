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
    /// PublicSendCodeForwardV3
    ///
    /// This API need the upgradeToken in request body.
    /// Available contexts for use :
    /// 1. **upgradeHeadlessAccount**
    /// The context is intended to be used whenever the email address wanted to be automatically verified on upgrading a headless account.
    /// If this context used, IAM rejects the request if the email address is already used by others by returning HTTP Status Code 409.
    /// </summary>
    public class PublicSendCodeForwardV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicSendCodeForwardV3Builder Builder { get => new PublicSendCodeForwardV3Builder(); }

        public class PublicSendCodeForwardV3Builder
            : OperationBuilder<PublicSendCodeForwardV3Builder>
        {





            internal PublicSendCodeForwardV3Builder() { }






            public PublicSendCodeForwardV3 Build(
                ModelSendVerificationCodeRequestV3 body
            )
            {
                PublicSendCodeForwardV3 op = new PublicSendCodeForwardV3(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicSendCodeForwardV3(PublicSendCodeForwardV3Builder builder,
            ModelSendVerificationCodeRequestV3 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicSendCodeForwardV3(
            Model.ModelSendVerificationCodeRequestV3 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/me/code/request/forward";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public string ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            var payloadString = Helper.ConvertInputStreamToString(payload);

            if (code == (HttpStatusCode)302)
            {
                return payloadString;
            }

            throw new HttpResponseException(code, payloadString);
        }
    }

}