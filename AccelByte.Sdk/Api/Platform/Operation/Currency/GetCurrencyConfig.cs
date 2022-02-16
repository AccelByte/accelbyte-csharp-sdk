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
    /// getCurrencyConfig
    ///
    /// [SERVICE COMMUNICATION ONLY] Get currency config by code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CURRENCY", action=2 (READ)
    ///   *  Returns : simplified Currency
    /// </summary>
    public class GetCurrencyConfig : AccelByte.Sdk.Core.Operation
    {
        public GetCurrencyConfig(
            string currencyCode,            
            string namespace_            
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/currencies/{currencyCode}/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CurrencyConfig? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CurrencyConfig>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CurrencyConfig>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}