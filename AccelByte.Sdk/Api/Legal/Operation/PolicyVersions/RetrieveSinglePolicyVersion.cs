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
    /// retrieveSinglePolicyVersion
    ///
    /// Retrieve a version of a particular country specific policy. If version is not provided, the Legal Service will assume caller requesting all versions from country-specific policy.
    /// </summary>
    public class RetrieveSinglePolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSinglePolicyVersionBuilder Builder { get => new RetrieveSinglePolicyVersionBuilder(); }

        public class RetrieveSinglePolicyVersionBuilder
            : OperationBuilder<RetrieveSinglePolicyVersionBuilder>
        {

            public string? VersionId { get; set; }





            internal RetrieveSinglePolicyVersionBuilder() { }


            public RetrieveSinglePolicyVersionBuilder SetVersionId(string _versionId)
            {
                VersionId = _versionId;
                return this;
            }





            public RetrieveSinglePolicyVersion Build(
                string policyId
            )
            {
                RetrieveSinglePolicyVersion op = new RetrieveSinglePolicyVersion(this,
                    policyId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RetrieveSinglePolicyVersion(RetrieveSinglePolicyVersionBuilder builder,
            string policyId
        )
        {
            PathParams["policyId"] = policyId;

            if (builder.VersionId is not null) QueryParams["versionId"] = builder.VersionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveSinglePolicyVersion(
            string policyId,
            string? versionId
        )
        {
            PathParams["policyId"] = policyId;

            if (versionId is not null) QueryParams["versionId"] = versionId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policies/{policyId}/versions";

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