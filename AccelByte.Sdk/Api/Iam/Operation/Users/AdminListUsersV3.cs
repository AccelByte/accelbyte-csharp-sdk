// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminListUsersV3
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:USER [READ] permission.
    /// 
    /// Returns list of users ID and namespace with their Justice platform account, under a namespace. If user
    /// doesn't have Justice platform account, the linkedPlatforms will be empty array.'
    /// </summary>
    public class AdminListUsersV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminListUsersV3(
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/platforms/justice";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountcommonListUsersWithPlatformAccountsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonListUsersWithPlatformAccountsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonListUsersWithPlatformAccountsResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}