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
    /// CreateRole
    ///
    /// 
    /// 
    /// Required permission 'ROLE:ADMIN [CREATE]' or 'ADMIN:ROLE [CREATE]'
    /// 
    /// 
    /// 
    /// 
    /// Required Permission 'ROLE:ADMIN [CREATE]' is going to be DEPRECATED for security purpose.
    /// It is going to be deprecated on 31 JANUARY 2019 , please use permission 'ADMIN:ROLE [CREATE]' instead.
    /// 
    /// 
    /// 
    /// 
    /// Role can only be assigned to other users by the role's manager.
    /// 
    /// 
    /// 
    /// 
    /// If role is an administrator role (i.e. AdminRole == true), it will list out the role's members.
    /// 
    /// 
    /// 
    /// 
    /// Administrator role can be created only when at least 1 manager is specified.
    /// </summary>
    public class CreateRole : AccelByte.Sdk.Core.Operation
    {
        public CreateRole(
            Model.ModelRoleCreateRequest body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/roles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.AccountcommonRole? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonRole>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonRole>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}