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
    /// bulkGetLocaleItems
    ///
    /// This API is used to bulk get locale items. If item not exist in specific region, default region item will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the list of items info
    /// </summary>
    public class BulkGetLocaleItems : AccelByte.Sdk.Core.Operation
    {
        public BulkGetLocaleItems(
            string namespace_,            
            bool? activeOnly,            
            string? language,            
            string? region,            
            string? storeId,            
            string itemIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (language != null) QueryParams["language"] = language;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (itemIds != null) QueryParams["itemIds"] = itemIds;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/locale/byIds";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ItemInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ItemInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ItemInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}