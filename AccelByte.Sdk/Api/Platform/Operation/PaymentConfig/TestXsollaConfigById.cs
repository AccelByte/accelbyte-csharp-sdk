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
    /// testXsollaConfigById
    ///
    ///  [Not supported yet in AGS Shared Cloud] Test xsolla configuration in payment merchant config. Reference: [Xsolla Document](https://developers.xsolla.com/?#simple-checkout).
    /// Other detail info:
    /// 
    ///   * Returns : test xsolla config
    /// </summary>
    public class TestXsollaConfigById : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestXsollaConfigByIdBuilder Builder { get => new TestXsollaConfigByIdBuilder(); }

        public class TestXsollaConfigByIdBuilder
            : OperationBuilder<TestXsollaConfigByIdBuilder>
        {





            internal TestXsollaConfigByIdBuilder() { }






            public TestXsollaConfigById Build(
                string id
            )
            {
                TestXsollaConfigById op = new TestXsollaConfigById(this,
                    id
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private TestXsollaConfigById(TestXsollaConfigByIdBuilder builder,
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public TestXsollaConfigById(
            string id
        )
        {
            PathParams["id"] = id;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/payment/config/merchant/{id}/xsollaconfig/test";

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