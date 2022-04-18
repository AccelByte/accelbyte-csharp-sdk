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
    /// fulfillUserOrder
    ///
    /// Fulfill an order if the order is charged but fulfill failed.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ORDER", action=4 (UPDATE)
    ///   *  Returns : fulfilled order
    /// </summary>
    public class FulfillUserOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FulfillUserOrderBuilder Builder = new FulfillUserOrderBuilder();

        public class FulfillUserOrderBuilder
            : OperationBuilder<FulfillUserOrderBuilder>
        {
            
            
            
            internal FulfillUserOrderBuilder() { }





            public FulfillUserOrder Build(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                FulfillUserOrder op = new FulfillUserOrder(this,
                    namespace_,                    
                    orderNo,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private FulfillUserOrder(FulfillUserOrderBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FulfillUserOrder(
            string namespace_,            
            string orderNo,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}/fulfill";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.OrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OrderInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}