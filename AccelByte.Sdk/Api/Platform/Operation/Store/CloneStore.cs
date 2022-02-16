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
    /// cloneStore
    ///
    /// This API is used to clone a store. Usually clone a draft store to published store because published store can't directly edit content.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:STORE", action=1 (CREATE)
    ///   *  Returns : clone store info
    /// </summary>
    public class CloneStore : AccelByte.Sdk.Core.Operation
    {
        public CloneStore(
            string namespace_,            
            string storeId,            
            string? targetStoreId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["storeId"] = storeId;
            
            if (targetStoreId != null) QueryParams["targetStoreId"] = targetStoreId;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/stores/{storeId}/clone";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.StoreInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StoreInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}