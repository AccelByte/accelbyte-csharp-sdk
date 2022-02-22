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
    /// featureItem
    ///
    /// Add a feature to an item.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=4 (UPDATE)
    ///   *  Returns : updated item
    /// </summary>
    public class FeatureItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FeatureItemBuilder Builder = new FeatureItemBuilder();

        public class FeatureItemBuilder
        {
            
            
            
            
            internal FeatureItemBuilder() { }





            public FeatureItem Build(
                string feature,
                string itemId,
                string namespace_,
                string storeId
            )
            {
                return new FeatureItem(this,
                    feature,                    
                    itemId,                    
                    namespace_,                    
                    storeId                    
                );
            }
        }

        private FeatureItem(FeatureItemBuilder builder,
            string feature,
            string itemId,
            string namespace_,
            string storeId
        )
        {
            PathParams["feature"] = feature;
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            
        }
        #endregion

        public FeatureItem(
            string feature,            
            string itemId,            
            string namespace_,            
            string storeId            
        )
        {
            PathParams["feature"] = feature;
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/features/{feature}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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