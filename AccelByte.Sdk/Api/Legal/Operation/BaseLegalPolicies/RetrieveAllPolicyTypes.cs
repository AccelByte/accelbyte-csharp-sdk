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
    /// retrieveAllPolicyTypes
    ///
    /// Retrieve all supported policy types.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrieveAllPolicyTypes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveAllPolicyTypesBuilder Builder = new RetrieveAllPolicyTypesBuilder();

        public class RetrieveAllPolicyTypesBuilder
            : OperationBuilder<RetrieveAllPolicyTypesBuilder>
        {
            public int? Offset { get; set; }
            
            
            internal RetrieveAllPolicyTypesBuilder() { }


            public RetrieveAllPolicyTypesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }




            public RetrieveAllPolicyTypes Build(
                int limit
            )
            {
                RetrieveAllPolicyTypes op = new RetrieveAllPolicyTypes(this,
                    limit                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveAllPolicyTypes(RetrieveAllPolicyTypesBuilder builder,
            int limit
        )
        {
            
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrieveAllPolicyTypes(
            int? offset,            
            int limit            
        )
        {
            
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/policy-types";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.RetrievePolicyTypeResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyTypeResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyTypeResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}