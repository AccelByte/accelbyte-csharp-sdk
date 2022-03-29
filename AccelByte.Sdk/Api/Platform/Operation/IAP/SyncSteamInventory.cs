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
    /// syncSteamInventory
    ///
    /// Sync steam inventory's items.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncSteamInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncSteamInventoryBuilder Builder = new SyncSteamInventoryBuilder();

        public class SyncSteamInventoryBuilder
        {
            
            
            public Model.SteamSyncRequest? Body { get; set; }
            
            internal SyncSteamInventoryBuilder() { }



            public SyncSteamInventoryBuilder SetBody(Model.SteamSyncRequest _body)
            {
                Body = _body;
                return this;
            }



            public SyncSteamInventory Build(
                string namespace_,
                string userId
            )
            {
                return new SyncSteamInventory(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private SyncSteamInventory(SyncSteamInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public SyncSteamInventory(
            string namespace_,            
            string userId,            
            Model.SteamSyncRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/steam/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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