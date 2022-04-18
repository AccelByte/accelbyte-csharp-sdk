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
    /// getAggregatePaymentProviders
    ///
    /// Get aggregate payment providers, such as XSOLLA, ADYEN.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : payment provider list
    /// </summary>
    public class GetAggregatePaymentProviders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAggregatePaymentProvidersBuilder Builder = new GetAggregatePaymentProvidersBuilder();

        public class GetAggregatePaymentProvidersBuilder
            : OperationBuilder<GetAggregatePaymentProvidersBuilder>
        {
            internal GetAggregatePaymentProvidersBuilder() { }





            public GetAggregatePaymentProviders Build(
            )
            {
                GetAggregatePaymentProviders op = new GetAggregatePaymentProviders(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetAggregatePaymentProviders(GetAggregatePaymentProvidersBuilder builder
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAggregatePaymentProviders(
        )
        {
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/provider/aggregate";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<string>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<string>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<string>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}