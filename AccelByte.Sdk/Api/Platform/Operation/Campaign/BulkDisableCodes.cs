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
    /// bulkDisableCodes
    ///
    /// Bulk disable codes.
    /// 
    /// Bulk disable campaign codes, all matched codes will be disabled except those have already been redeemed.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=4 (UPDATE)
    ///   *  Returns : the number of code actually disabled
    /// </summary>
    public class BulkDisableCodes : AccelByte.Sdk.Core.Operation
    {
        public BulkDisableCodes(
            string campaignId,            
            string namespace_,            
            int? batchNo            
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;
            
            if (batchNo != null) QueryParams["batchNo"] = Convert.ToString(batchNo)!;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/disable/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.BulkOperationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}