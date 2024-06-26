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
    /// retrieveSinglePolicy_1
    ///
    /// Retrieve a base policy.
    /// </summary>
    public class RetrieveSinglePolicy1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSinglePolicy1Builder Builder { get => new RetrieveSinglePolicy1Builder(); }

        public class RetrieveSinglePolicy1Builder
            : OperationBuilder<RetrieveSinglePolicy1Builder>
        {





            internal RetrieveSinglePolicy1Builder() { }






            public RetrieveSinglePolicy1 Build(
                string basePolicyId,
                string namespace_
            )
            {
                RetrieveSinglePolicy1 op = new RetrieveSinglePolicy1(this,
                    basePolicyId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RetrieveSinglePolicy1(RetrieveSinglePolicy1Builder builder,
            string basePolicyId,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveSinglePolicy1(
            string basePolicyId,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/base-policies/{basePolicyId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RetrieveBasePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RetrieveBasePolicyResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RetrieveBasePolicyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveBasePolicyResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}