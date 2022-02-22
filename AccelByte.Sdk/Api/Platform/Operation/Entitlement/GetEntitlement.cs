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
    /// getEntitlement
    ///
    /// Get entitlement.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ENTITLEMENT", action=2 (READ)
    ///   *  Returns : entitlement
    /// </summary>
    public class GetEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEntitlementBuilder Builder = new GetEntitlementBuilder();

        public class GetEntitlementBuilder
        {
            
            
            internal GetEntitlementBuilder() { }





            public GetEntitlement Build(
                string entitlementId,
                string namespace_
            )
            {
                return new GetEntitlement(this,
                    entitlementId,                    
                    namespace_                    
                );
            }
        }

        private GetEntitlement(GetEntitlementBuilder builder,
            string entitlementId,
            string namespace_
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public GetEntitlement(
            string entitlementId,            
            string namespace_            
        )
        {
            PathParams["entitlementId"] = entitlementId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/entitlements/{entitlementId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

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