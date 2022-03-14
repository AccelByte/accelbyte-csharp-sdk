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
    /// publicNormalizePaymentReturnUrl
    ///
    /// Normalize payment return url for payment provider
    /// Field                                                                                                                                                        | Type   | Required | Description
    /// -------------------------------------------------------------------------------------------------------------------------------------------------------------|--------|----------|-----------------------
    /// orderNo                                                                                                                                                      | String | Yes      | order no
    /// paymentStatus                                                                                                                                                | String | Yes      |
    /// 
    ///   * DONE: The payment was successfully completed.
    ///   * CANCELLED: The payment was cancelled by the shopper before completion, or the shopper returned to the merchant's site before completing the transaction.
    ///   * PENDING: Inform the shopper that you've received their order, and are waiting for the payment to be completed.
    /// 
    /// When the shopper has completed the payment you will receive a successful AUTHORISATION.
    ///   * RECEIVED: Inform the shopper that you've received their order, and are waiting for the payment to clear.
    ///   * UNKNOWN: An error occurred during the payment processing.
    ///   * FAILED: Shopper paid failed because of various reasons.
    /// 
    /// 
    /// reason                                                                                                                                                       | String | No       | payment status reason
    /// 
    /// Other detail info:
    /// 
    ///   * xsolla : parameters 'user_id', 'foreinginvoice', 'invoice_id' and 'status' will be automatically added to the link
    ///   *  adyen : https://docs.adyen.com/developers/checkout/web-sdk
    /// </summary>
    public class PublicNormalizePaymentReturnUrl : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicNormalizePaymentReturnUrlBuilder Builder = new PublicNormalizePaymentReturnUrlBuilder();

        public class PublicNormalizePaymentReturnUrlBuilder
        {
            
            public string? PayerID { get; set; }
            
            public string? Foreinginvoice { get; set; }
            
            public string? InvoiceId { get; set; }
            
            public string? Payload { get; set; }
            
            public string? RedirectResult { get; set; }
            
            public string? ResultCode { get; set; }
            
            public string? SessionId { get; set; }
            
            public string? Status { get; set; }
            
            public string? Token { get; set; }
            
            public string? Type { get; set; }
            
            public string? UserId { get; set; }
            
            
            
            
            
            internal PublicNormalizePaymentReturnUrlBuilder() { }


            public PublicNormalizePaymentReturnUrlBuilder SetPayerID(string _payerID)
            {
                PayerID = _payerID;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetForeinginvoice(string _foreinginvoice)
            {
                Foreinginvoice = _foreinginvoice;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetInvoiceId(string _invoiceId)
            {
                InvoiceId = _invoiceId;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetPayload(string _payload)
            {
                Payload = _payload;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetRedirectResult(string _redirectResult)
            {
                RedirectResult = _redirectResult;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetResultCode(string _resultCode)
            {
                ResultCode = _resultCode;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetSessionId(string _sessionId)
            {
                SessionId = _sessionId;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetStatus(string _status)
            {
                Status = _status;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetToken(string _token)
            {
                Token = _token;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetType(string _type)
            {
                Type = _type;
                return this;
            }

            public PublicNormalizePaymentReturnUrlBuilder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }




            public PublicNormalizePaymentReturnUrl Build(
                string namespace_,
                string orderNo,
                string paymentOrderNo,
                string paymentProvider,
                string returnUrl
            )
            {
                return new PublicNormalizePaymentReturnUrl(this,
                    namespace_,                    
                    orderNo,                    
                    paymentOrderNo,                    
                    paymentProvider,                    
                    returnUrl                    
                );
            }
        }

        private PublicNormalizePaymentReturnUrl(PublicNormalizePaymentReturnUrlBuilder builder,
            string namespace_,
            string orderNo,
            string paymentOrderNo,
            string paymentProvider,
            string returnUrl
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.PayerID != null) QueryParams["PayerID"] = builder.PayerID;
            if (builder.Foreinginvoice != null) QueryParams["foreinginvoice"] = builder.Foreinginvoice;
            if (builder.InvoiceId != null) QueryParams["invoice_id"] = builder.InvoiceId;
            if (builder.Payload != null) QueryParams["payload"] = builder.Payload;
            if (builder.RedirectResult != null) QueryParams["redirectResult"] = builder.RedirectResult;
            if (builder.ResultCode != null) QueryParams["resultCode"] = builder.ResultCode;
            if (builder.SessionId != null) QueryParams["sessionId"] = builder.SessionId;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            if (builder.Token != null) QueryParams["token"] = builder.Token;
            if (builder.Type != null) QueryParams["type"] = builder.Type;
            if (builder.UserId != null) QueryParams["user_id"] = builder.UserId;
            if (orderNo != null) QueryParams["orderNo"] = orderNo;
            if (paymentOrderNo != null) QueryParams["paymentOrderNo"] = paymentOrderNo;
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            if (returnUrl != null) QueryParams["returnUrl"] = returnUrl;
            
            
            
            
        }
        #endregion

        public PublicNormalizePaymentReturnUrl(
            string namespace_,            
            string? payerID,            
            string? foreinginvoice,            
            string? invoiceId,            
            string? payload,            
            string? redirectResult,            
            string? resultCode,            
            string? sessionId,            
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
            if (redirectResult != null) QueryParams["redirectResult"] = redirectResult;
            if (resultCode != null) QueryParams["resultCode"] = resultCode;
            if (sessionId != null) QueryParams["sessionId"] = sessionId;
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