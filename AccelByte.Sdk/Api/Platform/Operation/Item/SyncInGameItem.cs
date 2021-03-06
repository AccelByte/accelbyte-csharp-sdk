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
    /// syncInGameItem
    ///
    /// This API is used to sync an in game item in game namespace to publisher namespace, at current BUNDLE can't be synced.
    /// 
    /// The synced item has an additional field targetItemId besides targetNamespace, mostly this item should not modified manually again.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=4 (UPDATE)
    ///   *  Returns : item data
    /// </summary>
    public class SyncInGameItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncInGameItemBuilder Builder = new SyncInGameItemBuilder();

        public class SyncInGameItemBuilder
            : OperationBuilder<SyncInGameItemBuilder>
        {


            public Model.InGameItemSync? Body { get; set; }




            internal SyncInGameItemBuilder() { }



            public SyncInGameItemBuilder SetBody(Model.InGameItemSync _body)
            {
                Body = _body;
                return this;
            }




            public SyncInGameItem Build(
                string namespace_,
                string storeId
            )
            {
                SyncInGameItem op = new SyncInGameItem(this,
                    namespace_,                    
                    storeId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SyncInGameItem(SyncInGameItemBuilder builder,
            string namespace_,
            string storeId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncInGameItem(
            string namespace_,            
            string storeId,            
            Model.InGameItemSync body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (storeId is not null) QueryParams["storeId"] = storeId;
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.FullItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FullItemInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}