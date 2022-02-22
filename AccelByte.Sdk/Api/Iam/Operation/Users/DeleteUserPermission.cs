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
    /// DeleteUserPermission
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:PERMISSION:USER:{userId} [DELETE]'
    /// </summary>
    public class DeleteUserPermission : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserPermissionBuilder Builder = new DeleteUserPermissionBuilder();

        public class DeleteUserPermissionBuilder
        {
            
            
            
            
            internal DeleteUserPermissionBuilder() { }





            public DeleteUserPermission Build(
                long action,
                string namespace_,
                string resource,
                string userId
            )
            {
                return new DeleteUserPermission(this,
                    action,                    
                    namespace_,                    
                    resource,                    
                    userId                    
                );
            }
        }

        private DeleteUserPermission(DeleteUserPermissionBuilder builder,
            long action,
            string namespace_,
            string resource,
            string userId
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public DeleteUserPermission(
            long action,            
            string namespace_,            
            string resource,            
            string userId            
        )
        {
            PathParams["action"] = Convert.ToString(action);
            PathParams["namespace"] = namespace_;
            PathParams["resource"] = resource;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/permissions/{resource}/{action}";

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