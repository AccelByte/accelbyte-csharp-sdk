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
    /// syncEpicGamesInventory
    ///
    /// Sync epic games inventory's items.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncEpicGamesInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncEpicGamesInventoryBuilder Builder = new SyncEpicGamesInventoryBuilder();

        public class SyncEpicGamesInventoryBuilder
        {
            
            
            public Model.EpicGamesReconcileRequest? Body { get; set; }
            
            internal SyncEpicGamesInventoryBuilder() { }



            public SyncEpicGamesInventoryBuilder SetBody(Model.EpicGamesReconcileRequest _body)
            {
                Body = _body;
                return this;
            }



            public SyncEpicGamesInventory Build(
                string namespace_,
                string userId
            )
            {
                return new SyncEpicGamesInventory(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private SyncEpicGamesInventory(SyncEpicGamesInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public SyncEpicGamesInventory(
            string namespace_,            
            string userId,            
            Model.EpicGamesReconcileRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/epicgames/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.EpicGamesReconcileResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.EpicGamesReconcileResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.EpicGamesReconcileResult>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}