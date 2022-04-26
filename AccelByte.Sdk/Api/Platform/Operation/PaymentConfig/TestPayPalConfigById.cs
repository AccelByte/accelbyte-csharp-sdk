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
    /// testPayPalConfigById
    ///
    /// Test PayPal configuration in payment merchant config. Other detail info:
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : test result
    /// </summary>
    public class TestPayPalConfigById : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestPayPalConfigByIdBuilder Builder = new TestPayPalConfigByIdBuilder();

        public class TestPayPalConfigByIdBuilder
            : OperationBuilder<TestPayPalConfigByIdBuilder>
        {
            
            public bool? Sandbox { get; set; }
            
            internal TestPayPalConfigByIdBuilder() { }


            public TestPayPalConfigByIdBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public TestPayPalConfigById Build(
                string id
            )
            {
                TestPayPalConfigById op = new TestPayPalConfigById(this,
                    id                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private TestPayPalConfigById(TestPayPalConfigByIdBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;
            
            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestPayPalConfigById(
            string id,            
            bool? sandbox            
        )
        {
            PathParams["id"] = id;
            
            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/paypalconfig/test";

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