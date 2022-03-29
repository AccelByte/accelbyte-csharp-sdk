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
    /// publicConsumeUserEntitlement
    ///
    /// Consume user entitlement. If the entitlement useCount is 0, the status will be CONSUMED.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=4 (UPDATE)
    ///   *  Returns : consumed entitlement
    /// </summary>
    public class PublicConsumeUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicConsumeUserEntitlementBuilder Builder = new PublicConsumeUserEntitlementBuilder();

        public class PublicConsumeUserEntitlementBuilder
        {
            
            
            
            public Model.EntitlementDecrement? Body { get; set; }
            
            internal PublicConsumeUserEntitlementBuilder() { }



            public PublicConsumeUserEntitlementBuilder SetBody(Model.EntitlementDecrement _body)
            {
                Body = _body;
                return this;
            }



            public PublicConsumeUserEntitlement Build(
                string entitlementId,
                string namespace_,
                string userId
            )
            {
                return new PublicConsumeUserEntitlement(this,
                    entitlementId,                    
                    namespace_,                    
                    userId                    
                );
            }
        }

        private PublicConsumeUserEntitlement(PublicConsumeUserEntitlementBuilder builder,
            string entitlementId,
            string namespace_,
            string userId
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public PublicConsumeUserEntitlement(
            string entitlementId,            
            string namespace_,            
            string userId,            
            Model.EntitlementDecrement body            
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/entitlements/{entitlementId}/decrement";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.EntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.EntitlementInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}