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
    /// syncTwitchDropsEntitlement
    ///
    /// Sync twitch drops entitlements.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncTwitchDropsEntitlement : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncTwitchDropsEntitlementBuilder Builder = new SyncTwitchDropsEntitlementBuilder();

        public class SyncTwitchDropsEntitlementBuilder
            : OperationBuilder<SyncTwitchDropsEntitlementBuilder>
        {
            
            
            public Model.TwitchSyncRequest? Body { get; set; }
            
            internal SyncTwitchDropsEntitlementBuilder() { }



            public SyncTwitchDropsEntitlementBuilder SetBody(Model.TwitchSyncRequest _body)
            {
                Body = _body;
                return this;
            }




            public SyncTwitchDropsEntitlement Build(
                string namespace_,
                string userId
            )
            {
                SyncTwitchDropsEntitlement op = new SyncTwitchDropsEntitlement(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SyncTwitchDropsEntitlement(SyncTwitchDropsEntitlementBuilder builder,
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

        public SyncTwitchDropsEntitlement(
            string namespace_,            
            string userId,            
            Model.TwitchSyncRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/twitch/sync";

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