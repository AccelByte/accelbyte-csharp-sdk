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
    /// retrieveSinglePolicyVersion_1
    ///
    /// Retrieve a version of a particular country specific policy. If version is not provided, the Legal Service will assume caller requesting all versions from country-specific policy.
    /// </summary>
    public class RetrieveSinglePolicyVersion1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSinglePolicyVersion1Builder Builder { get => new RetrieveSinglePolicyVersion1Builder(); }

        public class RetrieveSinglePolicyVersion1Builder
            : OperationBuilder<RetrieveSinglePolicyVersion1Builder>
        {

            public string? VersionId { get; set; }





            internal RetrieveSinglePolicyVersion1Builder() { }


            public RetrieveSinglePolicyVersion1Builder SetVersionId(string _versionId)
            {
                VersionId = _versionId;
                return this;
            }





            public RetrieveSinglePolicyVersion1 Build(
                string namespace_,
                string policyId
            )
            {
                RetrieveSinglePolicyVersion1 op = new RetrieveSinglePolicyVersion1(this,
                    namespace_,
                    policyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RetrieveSinglePolicyVersion1(RetrieveSinglePolicyVersion1Builder builder,
            string namespace_,
            string policyId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyId"] = policyId;

            if (builder.VersionId is not null) QueryParams["versionId"] = builder.VersionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveSinglePolicyVersion1(
            string namespace_,
            string policyId,
            string? versionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["policyId"] = policyId;

            if (versionId is not null) QueryParams["versionId"] = versionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/policies/{policyId}/versions";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.RetrievePolicyVersionResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}