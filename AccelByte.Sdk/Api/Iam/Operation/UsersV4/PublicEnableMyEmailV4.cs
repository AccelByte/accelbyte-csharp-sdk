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
    /// PublicEnableMyEmailV4
    ///
    /// This endpoint is used to enable 2FA email.
    /// </summary>
    public class PublicEnableMyEmailV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicEnableMyEmailV4Builder Builder { get => new PublicEnableMyEmailV4Builder(); }

        public class PublicEnableMyEmailV4Builder
            : OperationBuilder<PublicEnableMyEmailV4Builder>
        {





            internal PublicEnableMyEmailV4Builder() { }






            public PublicEnableMyEmailV4 Build(
                string code,
                string namespace_
            )
            {
                PublicEnableMyEmailV4 op = new PublicEnableMyEmailV4(this,
                    code,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicEnableMyEmailV4(PublicEnableMyEmailV4Builder builder,
            string code,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (code is not null) FormParams["code"] = code;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicEnableMyEmailV4(
            string namespace_,
            string code
        )
        {
            PathParams["namespace"] = namespace_;


            if (code is not null) FormParams["code"] = code;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/email/enable";

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