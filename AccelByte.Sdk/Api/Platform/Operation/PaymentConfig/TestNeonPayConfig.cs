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
    /// testNeonPayConfig
    ///
    ///  [Not Supported Yet In Starter] Check Neon Pay configuration, Reference: [Neon Pay Document](https://docs.neonpay.com/docs/checkout).
    /// 
    /// #### Check List:
    /// 
    ///   * apiKey
    ///   * webhookSecretKey
    /// 
    /// Other detail info:
    ///   * Returns : test result
    /// </summary>
    public class TestNeonPayConfig : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestNeonPayConfigBuilder Builder { get => new TestNeonPayConfigBuilder(); }

        public class TestNeonPayConfigBuilder
            : OperationBuilder<TestNeonPayConfigBuilder>
        {

            public bool? Sandbox { get; set; }


            public Model.NeonPayConfig? Body { get; set; }




            internal TestNeonPayConfigBuilder() { }


            public TestNeonPayConfigBuilder SetSandbox(bool _sandbox)
            {
                Sandbox = _sandbox;
                return this;
            }


            public TestNeonPayConfigBuilder SetBody(Model.NeonPayConfig _body)
            {
                Body = _body;
                return this;
            }




            public TestNeonPayConfig Build(
            )
            {
                TestNeonPayConfig op = new TestNeonPayConfig(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private TestNeonPayConfig(TestNeonPayConfigBuilder builder
        )
        {

            if (builder.Sandbox != null) QueryParams["sandbox"] = Convert.ToString(builder.Sandbox)!;




            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestNeonPayConfig(
            bool? sandbox,
            Model.NeonPayConfig body
        )
        {

            if (sandbox != null) QueryParams["sandbox"] = Convert.ToString(sandbox)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/neonpayconfig/test";

        public override HttpMethod Method => HttpMethod.Post;

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