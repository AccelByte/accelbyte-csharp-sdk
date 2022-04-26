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
    /// publicCreateUserOrder
    ///
    /// Create an order. The result contains the checkout link and payment token. User with permission SANDBOX will create sandbox order that not real paid for xsolla/alipay and not validate price for wxpay.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ORDER", action=1 (CREATE)
    ///   *  Optional permission(user with this permission will create sandbox order) : resource="SANDBOX", action=1 (CREATE)
    ///   * It will be forbidden while the user is banned: ORDER_INITIATE or ORDER_AND_PAYMENT
    ///   *  Returns : created order
    /// </summary>
    public class PublicCreateUserOrder : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateUserOrderBuilder Builder = new PublicCreateUserOrderBuilder();

        public class PublicCreateUserOrderBuilder
            : OperationBuilder<PublicCreateUserOrderBuilder>
        {
            
            
            public Model.OrderCreate? Body { get; set; }
            
            internal PublicCreateUserOrderBuilder() { }



            public PublicCreateUserOrderBuilder SetBody(Model.OrderCreate _body)
            {
                Body = _body;
                return this;
            }




            public PublicCreateUserOrder Build(
                string namespace_,
                string userId
            )
            {
                PublicCreateUserOrder op = new PublicCreateUserOrder(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicCreateUserOrder(PublicCreateUserOrderBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateUserOrder(
            string namespace_,            
            string userId,            
            Model.OrderCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/orders";

        public override HttpMethod Method => HttpMethod.Post;

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