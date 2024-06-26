// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getPlatformEntitlementConfig
    ///
    /// Get platform entitlement config list.
    /// Other detail info:
    /// 
    ///   * Returns : entitlement info
    /// </summary>
    public class GetPlatformEntitlementConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetPlatformEntitlementConfigBuilder Builder { get => new GetPlatformEntitlementConfigBuilder(); }

        public class GetPlatformEntitlementConfigBuilder
            : OperationBuilder<GetPlatformEntitlementConfigBuilder>
        {





            internal GetPlatformEntitlementConfigBuilder() { }






            public GetPlatformEntitlementConfig Build(
                string namespace_,
                GetPlatformEntitlementConfigPlatform platform
            )
            {
                GetPlatformEntitlementConfig op = new GetPlatformEntitlementConfig(this,
                    namespace_,
                    platform
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetPlatformEntitlementConfig(GetPlatformEntitlementConfigBuilder builder,
            string namespace_,
            GetPlatformEntitlementConfigPlatform platform
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetPlatformEntitlementConfig(
            string namespace_,
            GetPlatformEntitlementConfigPlatform platform
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platform"] = platform.Value;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/platforms/{platform}/entitlement/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.EntitlementPlatformConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.EntitlementPlatformConfigInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.EntitlementPlatformConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementPlatformConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

    public class GetPlatformEntitlementConfigPlatform : StringEnum<GetPlatformEntitlementConfigPlatform>
    {
        public static readonly GetPlatformEntitlementConfigPlatform Epic
            = new GetPlatformEntitlementConfigPlatform("Epic");

        public static readonly GetPlatformEntitlementConfigPlatform GooglePlay
            = new GetPlatformEntitlementConfigPlatform("GooglePlay");

        public static readonly GetPlatformEntitlementConfigPlatform IOS
            = new GetPlatformEntitlementConfigPlatform("IOS");

        public static readonly GetPlatformEntitlementConfigPlatform Nintendo
            = new GetPlatformEntitlementConfigPlatform("Nintendo");

        public static readonly GetPlatformEntitlementConfigPlatform Oculus
            = new GetPlatformEntitlementConfigPlatform("Oculus");

        public static readonly GetPlatformEntitlementConfigPlatform Other
            = new GetPlatformEntitlementConfigPlatform("Other");

        public static readonly GetPlatformEntitlementConfigPlatform Playstation
            = new GetPlatformEntitlementConfigPlatform("Playstation");

        public static readonly GetPlatformEntitlementConfigPlatform Steam
            = new GetPlatformEntitlementConfigPlatform("Steam");

        public static readonly GetPlatformEntitlementConfigPlatform Xbox
            = new GetPlatformEntitlementConfigPlatform("Xbox");


        public static implicit operator GetPlatformEntitlementConfigPlatform(string value)
        {
            return NewValue(value);
        }

        public GetPlatformEntitlementConfigPlatform(string enumValue)
            : base(enumValue)
        {

        }
    }

}