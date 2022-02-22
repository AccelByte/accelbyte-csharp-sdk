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
    /// syncOrders
    ///
    /// Sync orders. If response contains nextEvaluatedKey, please use it as query param in the next call to fetch the next batch, a batch has 1000 elements or less.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:ORDER", action=2 (READ)
    ///   *  Returns : sync orders
    /// </summary>
    public class SyncOrders : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncOrdersBuilder Builder = new SyncOrdersBuilder();

        public class SyncOrdersBuilder
        {
            public string? NextEvaluatedKey { get; set; }
            
            
            
            internal SyncOrdersBuilder() { }


            public SyncOrdersBuilder SetNextEvaluatedKey(string _nextEvaluatedKey)
            {
                NextEvaluatedKey = _nextEvaluatedKey;
                return this;
            }




            public SyncOrders Build(
                string end,
                string start
            )
            {
                return new SyncOrders(this,
                    end,                    
                    start                    
                );
            }
        }

        private SyncOrders(SyncOrdersBuilder builder,
            string end,
            string start
        )
        {
            
            if (builder.NextEvaluatedKey != null) QueryParams["nextEvaluatedKey"] = builder.NextEvaluatedKey;
            if (end != null) QueryParams["end"] = end;
            if (start != null) QueryParams["start"] = start;
            
            
            
            
        }
        #endregion

        public SyncOrders(
            string? nextEvaluatedKey,            
            string end,            
            string start            
        )
        {
            
            if (nextEvaluatedKey != null) QueryParams["nextEvaluatedKey"] = nextEvaluatedKey;
            if (end != null) QueryParams["end"] = end;
            if (start != null) QueryParams["start"] = start;
            
            
            
            
        }

        public override string Path => "/platform/admin/orders";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OrderSyncResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderSyncResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderSyncResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}