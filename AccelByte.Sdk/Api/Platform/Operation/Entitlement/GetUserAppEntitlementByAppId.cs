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
    /// getUserAppEntitlementByAppId
    ///
    /// Get user app entitlement by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=2 (READ)
    /// </summary>
    public class GetUserAppEntitlementByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserAppEntitlementByAppIdBuilder Builder = new GetUserAppEntitlementByAppIdBuilder();

        public class GetUserAppEntitlementByAppIdBuilder
        {
            
            
            public bool? ActiveOnly { get; set; }
            
            
            internal GetUserAppEntitlementByAppIdBuilder() { }


            public GetUserAppEntitlementByAppIdBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }




            public GetUserAppEntitlementByAppId Build(
                string namespace_,
                string userId,
                string appId
            )
            {
                return new GetUserAppEntitlementByAppId(this,
                    namespace_,                    
                    userId,                    
                    appId                    
                );
            }
        }

        private GetUserAppEntitlementByAppId(GetUserAppEntitlementByAppIdBuilder builder,
            string namespace_,
            string userId,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (appId != null) QueryParams["appId"] = appId;
            
            
            
            
        }
        #endregion

        public GetUserAppEntitlementByAppId(
            string namespace_,            
            string userId,            
            bool? activeOnly,            
            string appId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (appId != null) QueryParams["appId"] = appId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AppEntitlementInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppEntitlementInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}