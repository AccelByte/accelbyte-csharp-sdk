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
    /// publicListCurrencies
    ///
    /// List currencies of a namespace.
    /// Other detail info:
    /// 
    ///   * Returns : Currency List
    /// </summary>
    public class PublicListCurrencies : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListCurrenciesBuilder Builder = new PublicListCurrenciesBuilder();

        public class PublicListCurrenciesBuilder
        {
            
            internal PublicListCurrenciesBuilder() { }





            public PublicListCurrencies Build(
                string namespace_
            )
            {
                return new PublicListCurrencies(this,
                    namespace_                    
                );
            }
        }

        private PublicListCurrencies(PublicListCurrenciesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public PublicListCurrencies(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/currencies";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.CurrencyInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.CurrencyInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.CurrencyInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}