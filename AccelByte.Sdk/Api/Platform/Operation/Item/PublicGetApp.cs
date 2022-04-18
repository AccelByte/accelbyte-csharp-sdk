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
    /// publicGetApp
    ///
    /// This API is used to get an app in locale. If app not exist in specific region, default region app will return.
    /// 
    /// Other detail info:
    /// 
    ///   * Optional permission : resource="PREVIEW", action=1(CREATE) (user with this permission can view draft store app)
    ///   *  Optional permission : resource="SANDBOX", action=1(CREATE) (user with this permission can view draft store app)
    ///   *  Returns : app data
    /// </summary>
    public class PublicGetApp : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetAppBuilder Builder = new PublicGetAppBuilder();

        public class PublicGetAppBuilder
            : OperationBuilder<PublicGetAppBuilder>
        {
            
            
            public string? Language { get; set; }
            
            public string? Region { get; set; }
            
            public string? StoreId { get; set; }
            
            internal PublicGetAppBuilder() { }


            public PublicGetAppBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }

            public PublicGetAppBuilder SetRegion(string _region)
            {
                Region = _region;
                return this;
            }

            public PublicGetAppBuilder SetStoreId(string _storeId)
            {
                StoreId = _storeId;
                return this;
            }




            public PublicGetApp Build(
                string itemId,
                string namespace_
            )
            {
                PublicGetApp op = new PublicGetApp(this,
                    itemId,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetApp(PublicGetAppBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (builder.Language != null) QueryParams["language"] = builder.Language;
            if (builder.Region != null) QueryParams["region"] = builder.Region;
            if (builder.StoreId != null) QueryParams["storeId"] = builder.StoreId;
            
            
            
            

        }
        #endregion

        public PublicGetApp(
            string itemId,            
            string namespace_,            
            string? language,            
            string? region,            
            string? storeId            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            if (language != null) QueryParams["language"] = language;
            if (region != null) QueryParams["region"] = region;
            if (storeId != null) QueryParams["storeId"] = storeId;
            
            
            
            

        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/{itemId}/app/locale";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AppInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AppInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AppInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}