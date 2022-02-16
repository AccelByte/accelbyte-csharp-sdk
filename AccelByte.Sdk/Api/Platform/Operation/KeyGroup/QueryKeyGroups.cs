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
    /// queryKeyGroups
    ///
    /// Query key groups, if name is presented, it's fuzzy match.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=2 (READ)
    ///   *  Returns : slice of key group
    /// </summary>
    public class QueryKeyGroups : AccelByte.Sdk.Core.Operation
    {
        public QueryKeyGroups(
            string namespace_,            
            int? limit,            
            string? name,            
            int? offset,            
            string? tag            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name != null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (tag != null) QueryParams["tag"] = tag;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.KeyGroupPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}