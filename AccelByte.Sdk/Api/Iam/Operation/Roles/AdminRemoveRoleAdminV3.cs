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
    /// AdminRemoveRoleAdminV3
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:ROLE [UPDATE]'
    /// 
    /// code: 10413
    /// </summary>
    public class AdminRemoveRoleAdminV3 : AccelByte.Sdk.Core.Operation
    {
        public AdminRemoveRoleAdminV3(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/roles/{roleId}/admin";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}