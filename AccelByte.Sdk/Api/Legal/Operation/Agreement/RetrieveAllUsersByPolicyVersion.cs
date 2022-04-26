// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveAllUsersByPolicyVersion
    ///
    /// This API will return all users who has accepted a specific policy version.Other detail info:
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveAllUsersByPolicyVersion : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllUsersByPolicyVersionBuilder Builder = new RetrieveAllUsersByPolicyVersionBuilder();

        public class RetrieveAllUsersByPolicyVersionBuilder
            : OperationBuilder<RetrieveAllUsersByPolicyVersionBuilder>
        {
            public string? Keyword { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            
            internal RetrieveAllUsersByPolicyVersionBuilder() { }


            public RetrieveAllUsersByPolicyVersionBuilder SetKeyword(string _keyword)
            {
                Keyword = _keyword;
                return this;
            }

            public RetrieveAllUsersByPolicyVersionBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public RetrieveAllUsersByPolicyVersionBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }





            public RetrieveAllUsersByPolicyVersion Build(
                string policyVersionId
            )
            {
                RetrieveAllUsersByPolicyVersion op = new RetrieveAllUsersByPolicyVersion(this,
                    policyVersionId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveAllUsersByPolicyVersion(RetrieveAllUsersByPolicyVersionBuilder builder,
            string policyVersionId
        )
        {
            
            if (builder.Keyword != null) QueryParams["keyword"] = builder.Keyword;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (policyVersionId != null) QueryParams["policyVersionId"] = policyVersionId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAllUsersByPolicyVersion(
            string? keyword,            
            int? limit,            
            int? offset,            
            string policyVersionId            
        )
        {
            
            if (keyword != null) QueryParams["keyword"] = keyword;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (policyVersionId != null) QueryParams["policyVersionId"] = policyVersionId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/agreements/policy-versions/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.PagedRetrieveUserAcceptedAgreementResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PagedRetrieveUserAcceptedAgreementResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PagedRetrieveUserAcceptedAgreementResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}