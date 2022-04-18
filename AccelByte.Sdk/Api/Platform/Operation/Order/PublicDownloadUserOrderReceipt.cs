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
    /// publicDownloadUserOrderReceipt
    ///
    /// Download user order receipt by orderNo.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ORDER", action=2 (READ)
    ///   *  Returns : order receipt pdf
    /// </summary>
    public class PublicDownloadUserOrderReceipt : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDownloadUserOrderReceiptBuilder Builder = new PublicDownloadUserOrderReceiptBuilder();

        public class PublicDownloadUserOrderReceiptBuilder
            : OperationBuilder<PublicDownloadUserOrderReceiptBuilder>
        {
            
            
            
            internal PublicDownloadUserOrderReceiptBuilder() { }





            public PublicDownloadUserOrderReceipt Build(
                string namespace_,
                string orderNo,
                string userId
            )
            {
                PublicDownloadUserOrderReceipt op = new PublicDownloadUserOrderReceipt(this,
                    namespace_,                    
                    orderNo,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicDownloadUserOrderReceipt(PublicDownloadUserOrderReceiptBuilder builder,
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

        public PublicDownloadUserOrderReceipt(
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

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/orders/{orderNo}/receipt.pdf";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/pdf" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}