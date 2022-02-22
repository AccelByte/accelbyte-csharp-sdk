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
    /// RemoveRoleManagers
    ///
    /// 
    /// 
    /// Required permission 'ROLE:ADMIN [UPDATE]' or 'ADMIN:ROLE [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// Required Permission 'ROLE:ADMIN [UPDATE]' is going to be DEPRECATED for security purpose.
    /// It is going to be deprecated on 31 JANUARY 2019 , please use permission 'ADMIN:ROLE [UPDATE]' instead.
    /// 
    /// 
    /// 
    /// 
    /// Role can only be assigned to other users by the role's manager.
    /// </summary>
    public class RemoveRoleManagers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RemoveRoleManagersBuilder Builder = new RemoveRoleManagersBuilder();

        public class RemoveRoleManagersBuilder
        {
            
            
            internal RemoveRoleManagersBuilder() { }





            public RemoveRoleManagers Build(
                ModelRoleManagersRequest body,
                string roleId
            )
            {
                return new RemoveRoleManagers(this,
                    body,                    
                    roleId                    
                );
            }
        }

        private RemoveRoleManagers(RemoveRoleManagersBuilder builder,
            ModelRoleManagersRequest body,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public RemoveRoleManagers(
            string roleId,            
            Model.ModelRoleManagersRequest body            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/roles/{roleId}/managers";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

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