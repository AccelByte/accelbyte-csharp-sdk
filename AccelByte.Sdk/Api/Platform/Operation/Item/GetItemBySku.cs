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
    /// getItemBySku
    ///
    /// This API is used to get the item by sku.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the item with sku
    /// </summary>
    public class GetItemBySku : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetItemBySkuBuilder Builder = new GetItemBySkuBuilder();

        public class GetItemBySkuBuilder
            : OperationBuilder<GetItemBySkuBuilder>
        {
            
            public bool? ActiveOnly { get; set; }
            
            public string? StoreId { get; set; }
            
            
            internal GetItemBySkuBuilder() { }


            public GetItemBySkuBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetItemBySkuBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public GetItemBySku Build(
                string namespace_,
                string sku
            )
            {
                GetItemBySku op = new GetItemBySku(this,
                    namespace_,                    
                    sku                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetItemBySku(GetItemBySkuBuilder builder,
            string namespace_,
            string sku
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (sku != null) QueryParams["sku"] = sku;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetItemBySku(
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
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/bySku";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

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