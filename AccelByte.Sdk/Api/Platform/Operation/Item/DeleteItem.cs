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
    /// deleteItem
    ///
    /// This API is used to delete an item permanently, usually for test purpose. DO NOT delete already published item.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=8 (DELETE)
    /// </summary>
    public class DeleteItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteItemBuilder Builder = new DeleteItemBuilder();

        public class DeleteItemBuilder
        {
            
            
            public string? StoreId { get; set; }
            
            internal DeleteItemBuilder() { }


            public DeleteItemBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public DeleteItem Build(
                string itemId,
                string namespace_
            )
            {
                return new DeleteItem(this,
                    itemId,                    
                    namespace_                    
                );
            }
        }

        private DeleteItem(DeleteItemBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            
        }
        #endregion

        public DeleteItem(
            string itemId,            
            string namespace_,            
            string? storeId            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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