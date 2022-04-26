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
    /// syncPaymentOrders
    ///
    /// Sync payment orders. If response contains nextEvaluatedKey, please use it as query param in the next call to fetch the next batch, a batch has 1000 elements or less.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT", action=2 (READ)
    ///   *  Returns : sync payment orders
    /// </summary>
    public class SyncPaymentOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncPaymentOrdersBuilder Builder = new SyncPaymentOrdersBuilder();

        public class SyncPaymentOrdersBuilder
            : OperationBuilder<SyncPaymentOrdersBuilder>
        {
            public string? NextEvaluatedKey { get; set; }
            
            
            
            internal SyncPaymentOrdersBuilder() { }


            public SyncPaymentOrdersBuilder SetNextEvaluatedKey(string _nextEvaluatedKey)
            {
                NextEvaluatedKey = _nextEvaluatedKey;
                return this;
            }





            public SyncPaymentOrders Build(
                string end,
                string start
            )
            {
                SyncPaymentOrders op = new SyncPaymentOrders(this,
                    end,                    
                    start                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SyncPaymentOrders(SyncPaymentOrdersBuilder builder,
            string end,
            string start
        )
        {
            
            if (builder.NextEvaluatedKey != null) QueryParams["nextEvaluatedKey"] = builder.NextEvaluatedKey;
            if (end != null) QueryParams["end"] = end;
            if (start != null) QueryParams["start"] = start;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncPaymentOrders(
            string? nextEvaluatedKey,            
            string end,            
            string start            
        )
        {
            
            if (nextEvaluatedKey != null) QueryParams["nextEvaluatedKey"] = nextEvaluatedKey;
            if (end != null) QueryParams["end"] = end;
            if (start != null) QueryParams["start"] = start;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.PaymentOrderSyncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderSyncResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderSyncResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}