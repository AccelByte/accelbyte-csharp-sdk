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
    /// platformAuthenticateSAMLV3Handler
    ///
    /// This endpoint authenticates user platform for SAML protocol. It validates user to its
    /// respective platforms. Deactivated or login-banned users are unable to login.
    /// ## Supported platforms:
    /// - **azure**
    /// Microsoft login page will redirects to this endpoint after login success
    /// as previously defined on authentication request SAML
    /// </summary>
    public class PlatformAuthenticateSAMLV3Handler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PlatformAuthenticateSAMLV3HandlerBuilder Builder { get => new PlatformAuthenticateSAMLV3HandlerBuilder(); }

        public class PlatformAuthenticateSAMLV3HandlerBuilder
            : OperationBuilder<PlatformAuthenticateSAMLV3HandlerBuilder>
        {

            public string? Code { get; set; }

            public string? Error { get; set; }





            internal PlatformAuthenticateSAMLV3HandlerBuilder() { }


            public PlatformAuthenticateSAMLV3HandlerBuilder SetCode(string _code)
            {
                Code = _code;
                return this;
            }

            public PlatformAuthenticateSAMLV3HandlerBuilder SetError(string _error)
            {
                Error = _error;
                return this;
            }





            public PlatformAuthenticateSAMLV3Handler Build(
                string platformId,
                string state
            )
            {
                PlatformAuthenticateSAMLV3Handler op = new PlatformAuthenticateSAMLV3Handler(this,
                    platformId,
                    state
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PlatformAuthenticateSAMLV3Handler(PlatformAuthenticateSAMLV3HandlerBuilder builder,
            string platformId,
            string state
        )
        {
            PathParams["platformId"] = platformId;

            if (builder.Code is not null) QueryParams["code"] = builder.Code;
            if (builder.Error is not null) QueryParams["error"] = builder.Error;
            if (state is not null) QueryParams["state"] = state;





            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PlatformAuthenticateSAMLV3Handler(
            string platformId,
            string? code,
            string? error,
            string state
        )
        {
            PathParams["platformId"] = platformId;

            if (code is not null) QueryParams["code"] = code;
            if (error is not null) QueryParams["error"] = error;
            if (state is not null) QueryParams["state"] = state;





            LocationQuery = "PLACEHOLDER";

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/sso/saml/platforms/{platformId}/authenticate";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { };

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