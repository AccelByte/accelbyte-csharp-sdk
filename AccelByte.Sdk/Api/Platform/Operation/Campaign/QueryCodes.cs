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
    /// queryCodes
    ///
    /// Query campaign codes.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=2 (READ) (READ)
    ///   *  Returns : list of codes
    /// </summary>
    public class QueryCodes : AccelByte.Sdk.Core.Operation
    {
        public QueryCodes(
            string campaignId,            
            string namespace_,            
            bool? activeOnly,            
            int? batchNo,            
            string? code,            
            int? limit,            
            int? offset            
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (batchNo != null) QueryParams["batchNo"] = Convert.ToString(batchNo)!;
            if (code != null) QueryParams["code"] = code;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CodeInfoPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CodeInfoPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}