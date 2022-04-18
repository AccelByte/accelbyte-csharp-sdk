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
    /// testCheckoutConfig
    ///
    /// Test checkout.com configuration.
    /// 
    /// #### Check List:
    /// 
    ///   * publicKey
    ///   * secretKey
    /// 
    /// Other detail info:
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=4 (UPDATE)
    ///   *  Returns : test result
    /// </summary>
    public class TestCheckoutConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestCheckoutConfigBuilder Builder = new TestCheckoutConfigBuilder();

        public class TestCheckoutConfigBuilder
            : OperationBuilder<TestCheckoutConfigBuilder>
        {
            public bool? Sandbox { get; set; }
            
            public Model.CheckoutConfig? Body { get; set; }
            
            internal TestCheckoutConfigBuilder() { }


            public TestCheckoutConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }


            public TestCheckoutConfigBuilder SetBody(Model.CheckoutConfig _body)
            {
                Body = _body;
                return this;
            }



            public TestCheckoutConfig Build(
            )
            {
                TestCheckoutConfig op = new TestCheckoutConfig(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private TestCheckoutConfig(TestCheckoutConfigBuilder builder
        )
        {
            
            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            
            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestCheckoutConfig(
            bool? sandbox,            
            Model.CheckoutConfig body            
        )
        {
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/checkoutconfig/test";

        public override HttpMethod Method => HttpMethod.Post;

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