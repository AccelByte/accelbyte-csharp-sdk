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
    /// mockFulfillIAPItem
    ///
    ///  [TEST FACILITY ONLY] Forbidden in live environment. Mock fulfill iap item without validate receipt.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class MockFulfillIAPItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static MockFulfillIAPItemBuilder Builder = new MockFulfillIAPItemBuilder();

        public class MockFulfillIAPItemBuilder
            : OperationBuilder<MockFulfillIAPItemBuilder>
        {
            
            
            public Model.MockIAPReceipt? Body { get; set; }
            
            internal MockFulfillIAPItemBuilder() { }



            public MockFulfillIAPItemBuilder SetBody(Model.MockIAPReceipt _body)
            {
                Body = _body;
                return this;
            }




            public MockFulfillIAPItem Build(
                string namespace_,
                string userId
            )
            {
                MockFulfillIAPItem op = new MockFulfillIAPItem(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private MockFulfillIAPItem(MockFulfillIAPItemBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public MockFulfillIAPItem(
            string namespace_,            
            string userId,            
            Model.MockIAPReceipt body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/iap/mock/receipt";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}