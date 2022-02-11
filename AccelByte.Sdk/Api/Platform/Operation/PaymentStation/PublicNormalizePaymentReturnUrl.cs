using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// publicNormalizePaymentReturnUrl
    ///
    /// Normalize payment return url for payment provider
    /// Payment response: Field| Type| Required| Description
    /// ---|---|---|---
    /// orderNo| String| Yes| order no
    /// paymentStatus| String| Yes|
    /// 
    ///   * DONE: The payment was successfully completed.
    ///   * CANCELLED: The payment was cancelled by the shopper before completion, or the shopper returned to the merchant's site before completing the transaction.
    ///   * PENDING: Inform the shopper that you've received their order, and are waiting for the payment to be completed. When the shopper has completed the payment you will receive a successful AUTHORISATION.
    ///   * RECEIVED: Inform the shopper that you've received their order, and are waiting for the payment to clear.
    ///   * UNKNOWN: An error occurred during the payment processing.
    ///   * FAILED: Shopper paid failed because of various reasons.
    /// 
    /// 
    /// reason| String| No| payment status reason
    /// Other detail info:
    /// 
    ///   * xsolla : parameters 'user_id', 'foreinginvoice', 'invoice_id' and 'status' will be automatically added to the link
    ///   *  adyen : https://docs.adyen.com/developers/checkout/web-sdk
    /// </summary>
    public class PublicNormalizePaymentReturnUrl : AccelByte.Sdk.Core.Operation
    {
        public PublicNormalizePaymentReturnUrl(
            string namespace_,            
            string? payerID,            
            string? foreinginvoice,            
            string? invoiceId,            
            string? payload,            
            string? resultCode,            
            string? status,            
            string? token,            
            string? type,            
            string? userId,            
            string orderNo,            
            string paymentOrderNo,            
            string paymentProvider,            
            string returnUrl            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (payerID != null) QueryParams["PayerID"] = payerID;
            if (foreinginvoice != null) QueryParams["foreinginvoice"] = foreinginvoice;
            if (invoiceId != null) QueryParams["invoice_id"] = invoiceId;
            if (payload != null) QueryParams["payload"] = payload;
            if (resultCode != null) QueryParams["resultCode"] = resultCode;
            if (status != null) QueryParams["status"] = status;
            if (token != null) QueryParams["token"] = token;
            if (type != null) QueryParams["type"] = type;
            if (userId != null) QueryParams["user_id"] = userId;
            if (orderNo != null) QueryParams["orderNo"] = orderNo;
            if (paymentOrderNo != null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            if (returnUrl != null) QueryParams["returnUrl"] = returnUrl;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/returnurl";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}