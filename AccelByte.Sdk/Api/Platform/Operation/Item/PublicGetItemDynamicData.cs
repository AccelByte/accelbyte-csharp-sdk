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
    /// publicGetItemDynamicData
    ///
    /// Get item dynamic data for a published item.
    /// Other detail info:
    /// 
    ///   * Returns : item dynamic data
    /// </summary>
    public class PublicGetItemDynamicData : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetItemDynamicDataBuilder Builder = new PublicGetItemDynamicDataBuilder();

        public class PublicGetItemDynamicDataBuilder
        {
            
            
            internal PublicGetItemDynamicDataBuilder() { }





            public PublicGetItemDynamicData Build(
                string itemId,
                string namespace_
            )
            {
                return new PublicGetItemDynamicData(this,
                    itemId,                    
                    namespace_                    
                );
            }
        }

        private PublicGetItemDynamicData(PublicGetItemDynamicDataBuilder builder,
            string itemId,
            string namespace_
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public PublicGetItemDynamicData(
            string itemId,            
            string namespace_            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/items/{itemId}/dynamic";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ItemDynamicDataInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemDynamicDataInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemDynamicDataInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}