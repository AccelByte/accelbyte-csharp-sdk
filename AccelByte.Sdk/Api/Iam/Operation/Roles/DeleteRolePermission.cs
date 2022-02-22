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
    /// DeleteRolePermission
    ///
    /// Required permission 'ROLE:ADMIN [UPDATE]' or 'ADMIN:ROLE [UPDATE]'
    /// 
    /// 
    /// Required Permission 'ROLE:ADMIN [UPDATE]' is going to be DEPRECATED for security purpose.
    /// It is going to be deprecated on 31 JANUARY 2019 , please use permission 'ADMIN:ROLE [UPDATE]' instead.
    /// </summary>
    public class DeleteRolePermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRolePermissionBuilder Builder = new DeleteRolePermissionBuilder();

        public class DeleteRolePermissionBuilder
        {
            
            
            
            internal DeleteRolePermissionBuilder() { }





            public DeleteRolePermission Build(
                long action,
                string resource,
                string roleId
            )
            {
                return new DeleteRolePermission(this,
                    action,                    
                    resource,                    
                    roleId                    
                );
            }
        }

        private DeleteRolePermission(DeleteRolePermissionBuilder builder,
            long action,
            string resource,
            string roleId
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;
            
            
            
            
            
        }
        #endregion

        public DeleteRolePermission(
            long action,            
            string resource,            
            string roleId            
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["resource"] = resource;
            PathParams["roleId"] = roleId;
            
            
            
            
            
        }

        public override string Path => "/iam/roles/{roleId}/permissions/{resource}/{action}";

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