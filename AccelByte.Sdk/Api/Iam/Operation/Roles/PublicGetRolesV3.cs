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
    /// PublicGetRolesV3
    ///
    /// 
    /// This endpoint is used to get all non-admin role.
    /// 
    /// 
    /// action code: 10418
    /// </summary>
    public class PublicGetRolesV3 : AccelByte.Sdk.Core.Operation
    {
        public PublicGetRolesV3(
            string? after,            
            string? before,            
            bool? isWildcard,            
            long? limit            
        )
        {
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (isWildcard != null) QueryParams["isWildcard"] = Convert.ToString(isWildcard)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelRoleNamesResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleNamesResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleNamesResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}