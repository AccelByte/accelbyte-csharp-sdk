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
    /// refundPaymentOrderByDedicated
    ///
    /// 
    /// 
    /// This API is used to refund payment order by paymentOrderNo from non justice service. e.g. dedicated server.
    /// 
    ///   * if the status field of response json is "REFUNDED", usually wallet paid, it indicates payment order already refunded
    ///   * if the status field of response json is "REFUNDING", usually real money paid, platform will send notification to registered notify url once refund successfully
    /// 
    /// 
    /// 
    /// Path Parameter:
    /// 
    /// 
    ///      Parameter     | Type   | Required | Description
    ///     ---------------|--------|----------|-----------------------------------------
    ///     namespace      | String | Yes      | Namespace that payment order resides in
    ///     paymentOrderNo | String | Yes      | Payment order number
    /// 
    /// 
    /// 
    ///  Request Body Parameters:
    /// 
    /// 
    ///      Parameter  | Type   | Required | Description
    ///     ------------|--------|----------|--------------------
    ///     description | String | Yes      | Refund description
    /// 
    /// 
    /// 
    ///  Request Body Example:
    /// 
    /// 
    ///     {
    /// 
    ///                "description": "Repeated item."
    /// 
    ///     }
    /// 
    /// `
    /// 
    /// #### Refund Notification:
    /// 
    /// It will send notification to configured web hook after refund successfully, http status code should return 200 or 204 once you resolve notification successfully, otherwise payment system will retry notification in interval
    /// 
    ///  Refund notification parameter:
    /// 
    /// 
    ///      Parameter | Type   | Required | Description
    ///     -----------|--------|----------|------------------------------------------------
    ///     payload    | String | Yes      | Refund notification payload in json string
    ///     sign       | String | Yes      | sha1 hex signature for payload and private key
    /// 
    /// 
    /// 
    ///  Refund notification Example:
    /// 
    /// 
    ///     {
    /// 
    ///            "payload": "{
    ///                "type": "payment",
    ///                "nonceStr": "34c1dcf3eb58455eb161465bbfc0b590",
    ///                "paymentOrderNo": "18081239088",
    ///                "namespace": "accelbyte",
    ///                "targetNamespace": "game1",
    ///                "targetUserId": "94451623768940d58416ca33ca767ec3",
    ///                "extOrderNo": "123456789",
    ///                "sku": "sku",
    ///                "extUserId": "678",
    ///                "price": 100,
    ///                "paymentProvider": "XSOLLA",
    ///                "vat": 0,
    ///                "salesTax": 0,
    ///                "paymentProviderFee": 0,
    ///                "paymentMethodFee": 0,
    ///                "currency": {
    ///                        "currencyCode": "USD",
    ///                        "currencySymbol": "$",
    ///                        "currencyType": "REAL",
    ///                        "namespace": "accelbyte",
    ///                        "decimals": 2
    ///                    },
    ///                "status": "REFUNDED",
    ///                "createdTime": "2018-07-28T00:39:16.274Z",
    ///                "chargedTime": "2018-07-28T00:39:16.274Z",
    ///                "refundedTime": "2018-07-28T00:39:16.274Z"
    ///            }",
    /// 
    ///            "sign":"e31fb92516cc9faaf50ad70343e1293acec6f3d5"
    /// 
    ///     }
    /// 
    /// `
    /// 
    ///  Refund notification payload parameter list:
    /// 
    /// 
    ///      Parameter         | Type     | Required | Description
    ///     -------------------|----------|----------|--------------------------------------------------------------------------------------
    ///     type               | String   | Yes      | Notification type: 'payment'
    ///     paymentOrderNo     | String   | Yes      | Payment system generated order number
    ///     extOrderNo         | String   | No       | External order number that passed by invoker
    ///     namespace          | String   | Yes      | Namespace that related payment order resides in
    ///     targetNamespace    | String   | Yes      | The game namespace
    ///     targetUserId       | String   | Yes      | The user id in game namespace
    ///     sku                | String   | No       | Item identify, it will return if pass it when create payment
    ///     extUserId          | String   | No       | External user id, can be character id, it will return if pass it when create payment
    ///     price              | int      | Yes      | Price of item
    ///     paymentProvider    | String   | Yes      | Payment provider: xsolla/alipay/wxpay/wallet
    ///     vat                | int      | Yes      | Payment order VAT
    ///     salesTax           | int      | Yes      | Payment order sales tax
    ///     paymentProviderFee | int      | Yes      | Payment provider fee
    ///     paymentMethodFee   | int      | Yes      | Payment method fee
    ///     currency           | Map      | Yes      | Payment order currency info
    ///     status             | String   | Yes      | Payment order status
    ///     statusReason       | String   | No       | Payment order refund status reason
    ///     createdTime        | Datetime | No       | The time of the order created
    ///     chargedTime        | Datetime | No       | The time of the order charged
    ///     refundedTime       | Datetime | No       | The time of the order refunded
    ///     customParameters   | Map      | No       | custom parameters, will return if pass it when create payment
    ///     nonceStr           | String   | Yes      | Random string, max length is 32,
    /// 
    /// 
    /// 
    /// Currency info parameter list:
    /// 
    /// 
    ///      Parameter     | Type   | Required | Description
    ///     ---------------|--------|----------|-----------------------------
    ///     currencyCode   | String | Yes      | Currency Code
    ///     currencySymbol | String | Yes      | Currency Symbol
    ///     currencyType   | String | Yes      | Currency type(REAL/VIRTUAL)
    ///     namespace      | String | Yes      | Currency namespace
    ///     decimals       | int    | Yes      | Currency decimals
    /// 
    /// 
    /// 
    /// #### Encryption Rule:
    /// 
    /// Concat payload json string and private key and then do sha1Hex.
    /// 
    /// #### Other detail info:
    /// 
    ///   * Token type : client token
    ///   *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:PAYMENT", action=4 (UPDATE)
    ///   *  cross namespace allowed
    /// </summary>
    public class RefundPaymentOrderByDedicated : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RefundPaymentOrderByDedicatedBuilder Builder = new RefundPaymentOrderByDedicatedBuilder();

        public class RefundPaymentOrderByDedicatedBuilder
            : OperationBuilder<RefundPaymentOrderByDedicatedBuilder>
        {
            
            
            public Model.PaymentOrderRefund? Body { get; set; }
            
            internal RefundPaymentOrderByDedicatedBuilder() { }



            public RefundPaymentOrderByDedicatedBuilder SetBody(Model.PaymentOrderRefund _body)
            {
                Body = _body;
                return this;
            }




            public RefundPaymentOrderByDedicated Build(
                string namespace_,
                string paymentOrderNo
            )
            {
                RefundPaymentOrderByDedicated op = new RefundPaymentOrderByDedicated(this,
                    namespace_,                    
                    paymentOrderNo                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RefundPaymentOrderByDedicated(RefundPaymentOrderByDedicatedBuilder builder,
            string namespace_,
            string paymentOrderNo
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RefundPaymentOrderByDedicated(
            string namespace_,            
            string paymentOrderNo,            
            Model.PaymentOrderRefund body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/payment/orders/{paymentOrderNo}/refund";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.PaymentOrderRefundResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderRefundResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentOrderRefundResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}