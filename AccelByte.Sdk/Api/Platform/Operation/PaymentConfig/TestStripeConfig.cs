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
    /// testStripeConfig
    ///
    /// Test stripe configuration.
    /// 
    /// #### Check List:
    /// 
    ///   * secretKey
    ///   * allowedPaymentMethodTypes
    /// 
    /// 
    /// 
    /// #### Non-check list:
    /// 
    ///   * publishableKey
    ///   * webhookSecret
    /// 
    /// Other detail info:
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : test adyen config
    /// </summary>
    public class TestStripeConfig : AccelByte.Sdk.Core.Operation
    {
        public TestStripeConfig(
            bool? sandbox,            
            Model.StripeConfig body            
        )
        {
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/payment/config/merchant/stripeconfig/test";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.TestResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}