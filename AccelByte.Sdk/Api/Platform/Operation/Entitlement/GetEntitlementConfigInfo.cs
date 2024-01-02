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
    /// getEntitlementConfigInfo
    ///
    /// Get entitlement config info.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ENTITLEMENT:CONFIG", action=2 (READ)
    ///   *  Returns : entitlement info
    /// </summary>
    public class GetEntitlementConfigInfo : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEntitlementConfigInfoBuilder Builder { get => new GetEntitlementConfigInfoBuilder(); }

        public class GetEntitlementConfigInfoBuilder
            : OperationBuilder<GetEntitlementConfigInfoBuilder>
        {

            public bool? WithoutCache { get; set; }





            internal GetEntitlementConfigInfoBuilder() { }


            public GetEntitlementConfigInfoBuilder SetWithoutCache(bool _withoutCache)
            {
                WithoutCache = _withoutCache;
                return this;
            }





            public GetEntitlementConfigInfo Build(
                string namespace_
            )
            {
                GetEntitlementConfigInfo op = new GetEntitlementConfigInfo(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetEntitlementConfigInfo(GetEntitlementConfigInfoBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.WithoutCache != null) QueryParams["withoutCache"] = Convert.ToString(builder.WithoutCache)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetEntitlementConfigInfo(
            string namespace_,
            bool? withoutCache
        )
        {
            PathParams["namespace"] = namespace_;

            if (withoutCache != null) QueryParams["withoutCache"] = Convert.ToString(withoutCache)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/entitlements/config/info";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.EntitlementConfigInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.EntitlementConfigInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.EntitlementConfigInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementConfigInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}