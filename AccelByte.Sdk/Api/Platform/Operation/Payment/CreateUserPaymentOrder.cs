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
    /// createUserPaymentOrder
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used to create payment order from justice service. The result contains the payment station url.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:PAYMENT", action=1 (CREATE)
    ///   * It will be forbidden while the user is banned: PAYMENT_INITIATE or ORDER_AND_PAYMENT
    ///   *  Returns : created order
    /// </summary>
    public class CreateUserPaymentOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateUserPaymentOrderBuilder Builder = new CreateUserPaymentOrderBuilder();

        public class CreateUserPaymentOrderBuilder
        {
            
            
            public Model.PaymentOrderCreate? Body { get; set; }
            
            internal CreateUserPaymentOrderBuilder() { }



            public CreateUserPaymentOrderBuilder SetBody(Model.PaymentOrderCreate _body)
            {
                Body = _body;
                return this;
            }



            public CreateUserPaymentOrder Build(
                string namespace_,
                string userId
            )
            {
                return new CreateUserPaymentOrder(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private CreateUserPaymentOrder(CreateUserPaymentOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreateUserPaymentOrder(
            string namespace_,            
            string userId,            
            Model.PaymentOrderCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/payment/orders";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentOrderInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}