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
    /// PublicEnableMyAuthenticatorV4
    ///
    /// This endpoint is used to enable 2FA authenticator.
    /// </summary>
    public class PublicEnableMyAuthenticatorV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicEnableMyAuthenticatorV4Builder Builder { get => new PublicEnableMyAuthenticatorV4Builder(); }

        public class PublicEnableMyAuthenticatorV4Builder
            : OperationBuilder<PublicEnableMyAuthenticatorV4Builder>
        {



            public string? Code { get; set; }



            internal PublicEnableMyAuthenticatorV4Builder() { }




            public PublicEnableMyAuthenticatorV4Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }



            public PublicEnableMyAuthenticatorV4 Build(
                string namespace_
            )
            {
                PublicEnableMyAuthenticatorV4 op = new PublicEnableMyAuthenticatorV4(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicEnableMyAuthenticatorV4(PublicEnableMyAuthenticatorV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;


            if (builder.Code is not null) FormParams["code"] = builder.Code;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicEnableMyAuthenticatorV4(
            string namespace_,
            string? code
        )
        {
            PathParams["namespace"] = namespace_;


            if (code is not null) FormParams["code"] = code;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/authenticator/enable";

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