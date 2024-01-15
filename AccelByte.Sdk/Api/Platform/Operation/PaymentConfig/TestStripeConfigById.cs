// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// testStripeConfigById
    ///
    ///  [Not Supported Yet In Starter] Test stripe configuration in payment merchant config. Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:PAYMENT:CONFIG", action=2 (READ)
    ///   *  Returns : test adyen config
    /// </summary>
    public class TestStripeConfigById : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestStripeConfigByIdBuilder Builder { get => new TestStripeConfigByIdBuilder(); }

        public class TestStripeConfigByIdBuilder
            : OperationBuilder<TestStripeConfigByIdBuilder>
        {

            public bool? Sandbox { get; set; }





            internal TestStripeConfigByIdBuilder() { }


            public TestStripeConfigByIdBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }





            public TestStripeConfigById Build(
                string id
            )
            {
                TestStripeConfigById op = new TestStripeConfigById(this,
                    id
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private TestStripeConfigById(TestStripeConfigByIdBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestStripeConfigById(
            string id,
            bool? sandbox
        )
        {
            PathParams["id"] = id;

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/stripeconfig/test";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.TestResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.TestResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.TestResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}