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
    /// publicGetItemByAppId
    ///
    /// This API is used to get item by appId.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store item)
    ///   *  Returns : the item with that appId
    /// </summary>
    public class PublicGetItemByAppId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetItemByAppIdBuilder Builder = new PublicGetItemByAppIdBuilder();

        public class PublicGetItemByAppIdBuilder
            : OperationBuilder<PublicGetItemByAppIdBuilder>
        {
            
            public string? Language { get; set; }
            
            public string? Region { get; set; }
            
            public string? StoreId { get; set; }
            
            
            internal PublicGetItemByAppIdBuilder() { }


            public PublicGetItemByAppIdBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetItemByAppIdBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicGetItemByAppIdBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }





            public PublicGetItemByAppId Build(
                string namespace_,
                string appId
            )
            {
                PublicGetItemByAppId op = new PublicGetItemByAppId(this,
                    namespace_,                    
                    appId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetItemByAppId(PublicGetItemByAppIdBuilder builder,
            string namespace_,
            string appId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            if (appId != null) QueryParams["appId"] = appId;
            

            
            
            

        }
        #endregion

        public PublicGetItemByAppId(
            string namespace_,            
            string? language,            
            string? region,            
            string? storeId,            
            string appId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            if (appId != null) QueryParams["appId"] = appId;
            

            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/byAppId";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ItemInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}