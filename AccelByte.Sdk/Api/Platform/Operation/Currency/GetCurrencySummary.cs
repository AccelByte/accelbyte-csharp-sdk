// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getCurrencySummary
    ///
    /// Get currency summary by code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CURRENCY", action=2 (READ)
    ///   *  Returns : simplified Currency
    /// </summary>
    public class GetCurrencySummary : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCurrencySummaryBuilder Builder = new GetCurrencySummaryBuilder();

        public class GetCurrencySummaryBuilder
            : OperationBuilder<GetCurrencySummaryBuilder>
        {
            
            
            internal GetCurrencySummaryBuilder() { }





            public GetCurrencySummary Build(
                string currencyCode,
                string namespace_
            )
            {
                GetCurrencySummary op = new GetCurrencySummary(this,
                    currencyCode,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetCurrencySummary(GetCurrencySummaryBuilder builder,
            string currencyCode,
            string namespace_
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetCurrencySummary(
            string currencyCode,            
            string namespace_            
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/summary";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.CurrencySummary? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CurrencySummary>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CurrencySummary>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}