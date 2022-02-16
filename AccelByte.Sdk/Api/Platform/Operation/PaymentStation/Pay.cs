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
    /// pay
    ///
    /// Do payment(For now, this only support checkout.com).
    /// Other detail info:
    /// 
    ///   * Returns : Payment process result
    /// </summary>
    public class Pay : AccelByte.Sdk.Core.Operation
    {
        public Pay(
            string namespace_,            
            string paymentOrderNo,            
            string? paymentProvider,            
            string? zipCode,            
            Model.PaymentToken body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["paymentOrderNo"] = paymentOrderNo;
            
            if (paymentProvider != null) QueryParams["paymentProvider"] = paymentProvider;
            if (zipCode != null) QueryParams["zipCode"] = zipCode;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/payment/orders/{paymentOrderNo}/pay";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.PaymentProcessResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.PaymentProcessResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.PaymentProcessResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}