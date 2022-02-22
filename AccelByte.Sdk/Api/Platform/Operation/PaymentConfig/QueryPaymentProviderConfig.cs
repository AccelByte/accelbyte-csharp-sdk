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
    /// queryPaymentProviderConfig
    ///
    /// Query payment provider config.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment provider config list
    /// </summary>
    public class QueryPaymentProviderConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryPaymentProviderConfigBuilder Builder = new QueryPaymentProviderConfigBuilder();

        public class QueryPaymentProviderConfigBuilder
        {
            public int? Limit { get; set; }
            
            public string? Namespace { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Region { get; set; }
            
            internal QueryPaymentProviderConfigBuilder() { }


            public QueryPaymentProviderConfigBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryPaymentProviderConfigBuilder SetNamespace(string _namespace_)
            {
                Namespace = _namespace_;
                return this;
            }

            public QueryPaymentProviderConfigBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryPaymentProviderConfigBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }




            public QueryPaymentProviderConfig Build(
            )
            {
                return new QueryPaymentProviderConfig(this
                );
            }
        }

        private QueryPaymentProviderConfig(QueryPaymentProviderConfigBuilder builder
        )
        {
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Namespace != null) QueryParams["namespace"] = builder.Namespace;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            
            
            
            
        }
        #endregion

        public QueryPaymentProviderConfig(
            int? limit,            
            string? namespace_,            
            int? offset,            
            string? region            
        )
        {
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (namespace_ != null) QueryParams["namespace"] = namespace_;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (region != null) QueryParams["region"] = region;
            
            
            
            
        }

        public override string Path => "/platform/admin/payment/config/provider";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentProviderConfigPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentProviderConfigPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}