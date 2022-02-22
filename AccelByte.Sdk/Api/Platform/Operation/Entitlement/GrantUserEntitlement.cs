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
    /// grantUserEntitlement
    ///
    /// Grant user entitlement.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:ENTITLEMENT", action=1 (CREATE)
    ///   *  Returns : granted entitlement
    /// </summary>
    public class GrantUserEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GrantUserEntitlementBuilder Builder = new GrantUserEntitlementBuilder();

        public class GrantUserEntitlementBuilder
        {
            
            
            public List<Model.EntitlementGrant>? Body { get; set; }
            
            internal GrantUserEntitlementBuilder() { }



            public GrantUserEntitlementBuilder SetBody(List<Model.EntitlementGrant> _body)
            {
                Body = _body;
                return this;
            }



            public GrantUserEntitlement Build(
                string namespace_,
                string userId
            )
            {
                return new GrantUserEntitlement(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private GrantUserEntitlement(GrantUserEntitlementBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public GrantUserEntitlement(
            string namespace_,            
            string userId,            
            List<Model.EntitlementGrant> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/entitlements";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.StackableEntitlementInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.StackableEntitlementInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.StackableEntitlementInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}