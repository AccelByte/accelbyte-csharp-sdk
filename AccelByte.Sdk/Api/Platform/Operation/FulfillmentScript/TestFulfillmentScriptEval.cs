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
    /// testFulfillmentScriptEval
    ///
    ///  [TEST FACILITY ONLY] Test eval fulfillment script.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:FULFILLMENT", action=2 (READ)
    /// </summary>
    public class TestFulfillmentScriptEval : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static TestFulfillmentScriptEvalBuilder Builder = new TestFulfillmentScriptEvalBuilder();

        public class TestFulfillmentScriptEvalBuilder
        {
            public Model.FulfillmentScriptEvalTestRequest? Body { get; set; }
            
            internal TestFulfillmentScriptEvalBuilder() { }



            public TestFulfillmentScriptEvalBuilder SetBody(Model.FulfillmentScriptEvalTestRequest _body)
            {
                Body = _body;
                return this;
            }



            public TestFulfillmentScriptEval Build(
            )
            {
                return new TestFulfillmentScriptEval(this
                );
            }
        }

        private TestFulfillmentScriptEval(TestFulfillmentScriptEvalBuilder builder
        )
        {
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public TestFulfillmentScriptEval(
            Model.FulfillmentScriptEvalTestRequest body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/fulfillment/scripts/tests/eval";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] {  };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.FulfillmentScriptEvalTestResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentScriptEvalTestResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentScriptEvalTestResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}