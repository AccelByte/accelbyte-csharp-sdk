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
    /// getItemIdBySku
    ///
    ///  [SERVICE COMMUNICATION ONLY] This API is used to get the itemId by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the itemId with sku
    /// </summary>
    public class GetItemIdBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetItemIdBySkuBuilder Builder = new GetItemIdBySkuBuilder();

        public class GetItemIdBySkuBuilder
        {
            
            public bool? ActiveOnly { get; set; }
            
            public string? StoreId { get; set; }
            
            
            internal GetItemIdBySkuBuilder() { }


            public GetItemIdBySkuBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetItemIdBySkuBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public GetItemIdBySku Build(
                string namespace_,
                string sku
            )
            {
                return new GetItemIdBySku(this,
                    namespace_,                    
                    sku                    
                );
            }
        }

        private GetItemIdBySku(GetItemIdBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            
        }
        #endregion

        public GetItemIdBySku(
            string namespace_,            
            bool? activeOnly,            
            string? storeId,            
            string sku            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/itemId/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ItemId? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemId>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemId>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}