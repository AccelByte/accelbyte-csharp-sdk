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
    /// retrieveLatestPolicies
    ///
    /// Retrieve all active latest policies based on a country.
    /// Other detail info:
    /// 
    ///   * Leave the policyType empty if you want to be responded with all policy type
    ///   *  Fill the tags if you want to filter the responded policy by tags
    ///   *  Fill the defaultOnEmpty with true if you want to be responded with default country-specific policy if your requested country is not exist
    /// </summary>
    public class RetrieveLatestPolicies : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveLatestPoliciesBuilder Builder = new RetrieveLatestPoliciesBuilder();

        public class RetrieveLatestPoliciesBuilder
            : OperationBuilder<RetrieveLatestPoliciesBuilder>
        {
            
            public bool? DefaultOnEmpty { get; set; }
            
            public string? PolicyType { get; set; }
            
            public string? Tags { get; set; }
            
            internal RetrieveLatestPoliciesBuilder() { }


            public RetrieveLatestPoliciesBuilder SetDefaultOnEmpty(bool _defaultOnEmpty)
            {
                DefaultOnEmpty = _defaultOnEmpty;
                return this;
            }

            public RetrieveLatestPoliciesBuilder SetPolicyType(string _policyType)
            {
                PolicyType = _policyType;
                return this;
            }

            public RetrieveLatestPoliciesBuilder SetTags(string _tags)
            {
                Tags = _tags;
                return this;
            }





            public RetrieveLatestPolicies Build(
                string countryCode
            )
            {
                RetrieveLatestPolicies op = new RetrieveLatestPolicies(this,
                    countryCode                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveLatestPolicies(RetrieveLatestPoliciesBuilder builder,
            string countryCode
        )
        {
            PathParams["countryCode"] = countryCode;
            
            if (builder.DefaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(builder.DefaultOnEmpty)!;
            if (builder.PolicyType != null) QueryParams["policyType"] = builder.PolicyType;
            if (builder.Tags != null) QueryParams["tags"] = builder.Tags;
            

            
            
            

        }
        #endregion

        public RetrieveLatestPolicies(
            string countryCode,            
            bool? defaultOnEmpty,            
            string? policyType,            
            string? tags            
        )
        {
            PathParams["countryCode"] = countryCode;
            
            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (policyType != null) QueryParams["policyType"] = policyType;
            if (tags != null) QueryParams["tags"] = tags;
            

            
            
            

        }

        public override string Path => "/agreement/public/policies/countries/{countryCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.RetrievePolicyPublicResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyPublicResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyPublicResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}