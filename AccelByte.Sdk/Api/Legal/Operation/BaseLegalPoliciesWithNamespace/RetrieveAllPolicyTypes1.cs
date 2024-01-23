// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveAllPolicyTypes_1
    ///
    /// Retrieve all supported policy types.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveAllPolicyTypes1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllPolicyTypes1Builder Builder { get => new RetrieveAllPolicyTypes1Builder(); }

        public class RetrieveAllPolicyTypes1Builder
            : OperationBuilder<RetrieveAllPolicyTypes1Builder>
        {

            public int? Offset { get; set; }





            internal RetrieveAllPolicyTypes1Builder() { }


            public RetrieveAllPolicyTypes1Builder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public RetrieveAllPolicyTypes1 Build(
                string namespace_,
                int limit
            )
            {
                RetrieveAllPolicyTypes1 op = new RetrieveAllPolicyTypes1(this,
                    namespace_,
                    limit
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RetrieveAllPolicyTypes1(RetrieveAllPolicyTypes1Builder builder,
            string namespace_,
            int limit
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAllPolicyTypes1(
            string namespace_,
            int? offset,
            int limit
        )
        {
            PathParams["namespace"] = namespace_;

            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            QueryParams["limit"] = Convert.ToString(limit)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policy-types";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.RetrievePolicyTypeResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.RetrievePolicyTypeResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.RetrievePolicyTypeResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyTypeResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}