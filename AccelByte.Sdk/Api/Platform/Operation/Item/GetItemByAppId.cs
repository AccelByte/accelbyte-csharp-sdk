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
    /// getItemByAppId
    ///
    /// This API is used to get the item by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=2 (READ)
    ///   *  Returns : the item with that appId
    /// </summary>
    public class GetItemByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetItemByAppIdBuilder Builder = new GetItemByAppIdBuilder();

        public class GetItemByAppIdBuilder
        {
            
            public bool? ActiveOnly { get; set; }
            
            public string? StoreId { get; set; }
            
            
            internal GetItemByAppIdBuilder() { }


            public GetItemByAppIdBuilder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public GetItemByAppIdBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public GetItemByAppId Build(
                string namespace_,
                string appId
            )
            {
                return new GetItemByAppId(this,
                    namespace_,                    
                    appId                    
                );
            }
        }

        private GetItemByAppId(GetItemByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (appId != null) QueryParams["appId"] = appId;
            
            
            
            
        }
        #endregion

        public GetItemByAppId(
            string namespace_,            
            bool? activeOnly,            
            string? storeId,            
            string appId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (appId != null) QueryParams["appId"] = appId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

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