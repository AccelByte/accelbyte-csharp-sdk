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
    /// PlatformTokenRequestHandler
    ///
    /// ## The endpoint is going to be deprecated
    /// This endpoint requires all requests to have Authorization header set with Basic access authentication
    /// constructed from client id and client secret. For publisher-game namespace schema : Specify only either platform_token or device_id. Device token grant
    /// should be requested along with device_id parameter against game namespace. Another 3rd party platform token grant should be requested
    /// along with platform_token parameter against publisher namespace.
    /// 
    /// Supported platforms:
    /// - **steamopenid**: Steam's user authentication method using OpenID 2.0. The expected value of the platform token is the URL generated by Steam on web authentication
    /// The JWT contains user's active bans with its expiry date. List of ban types can be obtained from /iam/bans..
    /// 
    /// ### Endpoint migration guide
    /// - **Substitute endpoint: _/iam/v3/oauth/platforms/{platformId}/token [POST]_**
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PlatformTokenRequestHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PlatformTokenRequestHandlerBuilder Builder { get => new PlatformTokenRequestHandlerBuilder(); }

        public class PlatformTokenRequestHandlerBuilder
            : OperationBuilder<PlatformTokenRequestHandlerBuilder>
        {



            public string? DeviceId { get; set; }

            public string? MacAddress { get; set; }

            public string? PlatformToken { get; set; }



            internal PlatformTokenRequestHandlerBuilder() { }




            public PlatformTokenRequestHandlerBuilder SetDeviceId(string _deviceId)
            {
                DeviceId = _deviceId;
                return this;
            }

            public PlatformTokenRequestHandlerBuilder SetMacAddress(string _macAddress)
            {
                MacAddress = _macAddress;
                return this;
            }

            public PlatformTokenRequestHandlerBuilder SetPlatformToken(string _platformToken)
            {
                PlatformToken = _platformToken;
                return this;
            }



            public PlatformTokenRequestHandler Build(
                string namespace_,
                string platformId
            )
            {
                PlatformTokenRequestHandler op = new PlatformTokenRequestHandler(this,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PlatformTokenRequestHandler(PlatformTokenRequestHandlerBuilder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;


            if (builder.DeviceId is not null) FormParams["device_id"] = builder.DeviceId;
            if (builder.MacAddress is not null) FormParams["macAddress"] = builder.MacAddress;
            if (builder.PlatformToken is not null) FormParams["platform_token"] = builder.PlatformToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PlatformTokenRequestHandler(
            string namespace_,
            string platformId,
            string? deviceId,
            string? macAddress,
            string? platformToken
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;


            if (deviceId is not null) FormParams["device_id"] = deviceId;
            if (macAddress is not null) FormParams["macAddress"] = macAddress;
            if (platformToken is not null) FormParams["platform_token"] = platformToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/oauth/namespaces/{namespace}/platforms/{platformId}/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.OauthmodelTokenResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}