// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// MatchPoolMetric
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:POOL:METRICS [READ]
    /// 
    /// Required Scope: social
    /// 
    /// Get metric for a specific match pool
    /// 
    /// Result: queueTime in seconds
    /// </summary>
    public class MatchPoolMetric : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static MatchPoolMetricBuilder Builder { get => new MatchPoolMetricBuilder(); }

        public class MatchPoolMetricBuilder
            : OperationBuilder<MatchPoolMetricBuilder>
        {





            internal MatchPoolMetricBuilder() { }






            public MatchPoolMetric Build(
                string namespace_,
                string pool
            )
            {
                MatchPoolMetric op = new MatchPoolMetric(this,
                    namespace_,
                    pool
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private MatchPoolMetric(MatchPoolMetricBuilder builder,
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public MatchPoolMetric(
            string namespace_,
            string pool
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["pool"] = pool;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-pools/{pool}/metrics";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiTicketMetricResultRecord? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiTicketMetricResultRecord>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiTicketMetricResultRecord>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiTicketMetricResultRecord>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}