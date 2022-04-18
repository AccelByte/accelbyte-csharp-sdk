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
    /// testWxPayConfigById
    ///
    /// Test WxPay configuration in payment merchant config. Reference: [WxPay Document](https://pay.weixin.qq.com/wiki/doc/api/native.php?chapter=9_1).
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : test WxPay config
    /// </summary>
    public class TestWxPayConfigById : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestWxPayConfigByIdBuilder Builder = new TestWxPayConfigByIdBuilder();

        public class TestWxPayConfigByIdBuilder
            : OperationBuilder<TestWxPayConfigByIdBuilder>
        {
            
            internal TestWxPayConfigByIdBuilder() { }





            public TestWxPayConfigById Build(
                string id
            )
            {
                TestWxPayConfigById op = new TestWxPayConfigById(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private TestWxPayConfigById(TestWxPayConfigByIdBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestWxPayConfigById(
            string id            
        )
        {
            PathParams["id"] = id;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/wxpayconfig/test";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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