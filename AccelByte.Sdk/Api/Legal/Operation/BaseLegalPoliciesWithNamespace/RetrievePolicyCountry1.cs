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
    /// retrievePolicyCountry_1
    ///
    /// Retrieve a Base Legal Policy based on a Particular Country.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrievePolicyCountry1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrievePolicyCountry1Builder Builder { get => new RetrievePolicyCountry1Builder(); }

        public class RetrievePolicyCountry1Builder
            : OperationBuilder<RetrievePolicyCountry1Builder>
        {





            internal RetrievePolicyCountry1Builder() { }






            public RetrievePolicyCountry1 Build(
                string basePolicyId,
                string countryCode,
                string namespace_
            )
            {
                RetrievePolicyCountry1 op = new RetrievePolicyCountry1(this,
                    basePolicyId,                    
                    countryCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrievePolicyCountry1(RetrievePolicyCountry1Builder builder,
            string basePolicyId,
            string countryCode,
            string namespace_
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrievePolicyCountry1(
            string basePolicyId,            
            string countryCode,            
            string namespace_            
        )
        {
            PathParams["basePolicyId"] = basePolicyId;
            PathParams["countryCode"] = countryCode;
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/agreement/admin/namespaces/{namespace}/base-policies/{basePolicyId}/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.RetrievePolicyResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RetrievePolicyResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrievePolicyResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}