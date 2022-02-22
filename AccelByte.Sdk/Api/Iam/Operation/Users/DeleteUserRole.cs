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
    /// DeleteUserRole
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [DELETE]'
    /// </summary>
    public class DeleteUserRole : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserRoleBuilder Builder = new DeleteUserRoleBuilder();

        public class DeleteUserRoleBuilder
        {
            
            
            
            internal DeleteUserRoleBuilder() { }





            public DeleteUserRole Build(
                string namespace_,
                string roleId,
                string userId
            )
            {
                return new DeleteUserRole(this,
                    namespace_,                    
                    roleId,                    
                    userId                    
                );
            }
        }

        private DeleteUserRole(DeleteUserRoleBuilder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public DeleteUserRole(
            string namespace_,            
            string roleId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json","text/plain" };

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