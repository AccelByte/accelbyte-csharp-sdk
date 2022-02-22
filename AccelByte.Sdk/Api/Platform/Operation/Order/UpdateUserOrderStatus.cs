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
    /// updateUserOrderStatus
    ///
    /// Update order status.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ORDER", action=4 (UPDATE)
    ///   *  Returns : updated order
    /// </summary>
    public class UpdateUserOrderStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateUserOrderStatusBuilder Builder = new UpdateUserOrderStatusBuilder();

        public class UpdateUserOrderStatusBuilder
        {
            
            
            
            public Model.OrderUpdate? Body { get; set; }
            
            internal UpdateUserOrderStatusBuilder() { }



            public UpdateUserOrderStatusBuilder SetBody(Model.OrderUpdate _body)
            {
                Body = _body;
                return this;
            }



            public UpdateUserOrderStatus Build(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                return new UpdateUserOrderStatus(this,
                    namespace_,                    
                    orderNo,                    
                    userId                    
                );
            }
        }

        private UpdateUserOrderStatus(UpdateUserOrderStatusBuilder builder,
            string namespace_,
            string orderNo,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdateUserOrderStatus(
            string namespace_,            
            string orderNo,            
            string userId,            
            Model.OrderUpdate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["orderNo"] = orderNo;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/orders/{orderNo}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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