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
    /// syncXboxInventory
    ///
    /// Sync Xbox inventory's items.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:IAP", action=4 (UPDATE)
    ///   *  Returns :
    /// </summary>
    public class SyncXboxInventory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncXboxInventoryBuilder Builder = new SyncXboxInventoryBuilder();

        public class SyncXboxInventoryBuilder
        {
            
            
            public Model.XblReconcileRequest? Body { get; set; }
            
            internal SyncXboxInventoryBuilder() { }



            public SyncXboxInventoryBuilder SetBody(Model.XblReconcileRequest _body)
            {
                Body = _body;
                return this;
            }



            public SyncXboxInventory Build(
                string namespace_,
                string userId
            )
            {
                return new SyncXboxInventory(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private SyncXboxInventory(SyncXboxInventoryBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public SyncXboxInventory(
            string namespace_,            
            string userId,            
            Model.XblReconcileRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/xbl/sync";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.XblReconcileResult>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.XblReconcileResult>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.XblReconcileResult>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}