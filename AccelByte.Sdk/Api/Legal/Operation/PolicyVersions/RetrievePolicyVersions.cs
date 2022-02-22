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
    /// retrievePolicyVersions
    ///
    /// [TODO] Retrieve one or more legal policies with its versions.
    /// If the basePolicyId not supplied, then retrieve only all latest policies version with localeId matched.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:*:LEGAL", action=2 (READ)
    /// </summary>
    public class RetrievePolicyVersions : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrievePolicyVersionsBuilder Builder = new RetrievePolicyVersionsBuilder();

        public class RetrievePolicyVersionsBuilder
        {
            public string? BasePolicyId { get; set; }
            
            public string? LocaleId { get; set; }
            
            public string? Namespace { get; set; }
            
            internal RetrievePolicyVersionsBuilder() { }


            public RetrievePolicyVersionsBuilder SetBasePolicyId(string _basePolicyId)
            {
                BasePolicyId = _basePolicyId;
                return this;
            }

            public RetrievePolicyVersionsBuilder SetLocaleId(string _localeId)
            {
                LocaleId = _localeId;
                return this;
            }

            public RetrievePolicyVersionsBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }




            public RetrievePolicyVersions Build(
            )
            {
                return new RetrievePolicyVersions(this
                );
            }
        }

        private RetrievePolicyVersions(RetrievePolicyVersionsBuilder builder
        )
        {
            
            if (builder.BasePolicyId != null) QueryParams["basePolicyId"] = builder.BasePolicyId;
            if (builder.LocaleId != null) QueryParams["localeId"] = builder.LocaleId;
            if (builder.Namespace != null) QueryParams["namespace"] = builder.Namespace;
            
            
            
            
        }
        #endregion

        public RetrievePolicyVersions(
            string? basePolicyId,            
            string? localeId,            
            string? namespace_            
        )
        {
            
            if (basePolicyId != null) QueryParams["basePolicyId"] = basePolicyId;
            if (localeId != null) QueryParams["localeId"] = localeId;
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            
            
            
            
        }

        public override string Path => "/agreement/public/policies";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.RetrievePolicyVersionResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrievePolicyVersionResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}