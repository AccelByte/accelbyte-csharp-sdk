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
    /// getCurrencyConfig
    ///
    /// [SERVICE COMMUNICATION ONLY] Get currency config by code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CURRENCY", action=2 (READ)
    ///   *  Returns : simplified Currency
    /// </summary>
    public class GetCurrencyConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrencyConfigBuilder Builder { get => new GetCurrencyConfigBuilder(); }

        public class GetCurrencyConfigBuilder
            : OperationBuilder<GetCurrencyConfigBuilder>
        {





            internal GetCurrencyConfigBuilder() { }






            public GetCurrencyConfig Build(
                string currencyCode,
                string namespace_
            )
            {
                GetCurrencyConfig op = new GetCurrencyConfig(this,
                    currencyCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetCurrencyConfig(GetCurrencyConfigBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCurrencyConfig(
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.CurrencyConfig? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.CurrencyConfig>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.CurrencyConfig>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CurrencyConfig>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}