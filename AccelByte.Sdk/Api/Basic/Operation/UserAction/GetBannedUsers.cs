// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getBannedUsers
    ///
    /// Get banned status.
    /// Unbanned users will not return, for example: request has 8 userIds, only 5 of then were banned, then the api will these 5 user status.Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE:{namespace}:ACTION" , action=2 (READ)
    /// </summary>
    public class GetBannedUsers : AccelByte.Sdk.Core.Operation
    {
        public GetBannedUsers(
            string namespace_,            
            List<string> userIds            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (userIds != null) QueryParams["userIds"] = userIds;
            
            
            CollectionFormatMap["userIds"] = "multi";
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/actions/banned";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ADTOObjectForEqu8UserBanStatus>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForEqu8UserBanStatus>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ADTOObjectForEqu8UserBanStatus>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}