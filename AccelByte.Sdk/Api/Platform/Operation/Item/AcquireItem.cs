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
    /// acquireItem
    ///
    ///  [SERVICE COMMUNICATION ONLY] This api is used for acquiring a published item while the item is maxCount limited, it will decrease the sale available count.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:ITEM", action=4 (UPDATE)
    ///   *  Returns : acquire result
    /// </summary>
    public class AcquireItem : AccelByte.Sdk.Core.Operation
    {
        public AcquireItem(
            string itemId,            
            string namespace_,            
            Model.ItemAcquireRequest body            
        )
        {
            PathParams["itemId"] = itemId;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/items/{itemId}/acquire";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ItemAcquireResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ItemAcquireResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ItemAcquireResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}