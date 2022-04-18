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
    /// AddUserRole
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:ROLE:USER:{userId} [UPDATE]'
    /// </summary>
    public class AddUserRole : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddUserRoleBuilder Builder = new AddUserRoleBuilder();

        public class AddUserRoleBuilder
            : OperationBuilder<AddUserRoleBuilder>
        {
            
            
            
            internal AddUserRoleBuilder() { }





            public AddUserRole Build(
                string namespace_,
                string roleId,
                string userId
            )
            {
                AddUserRole op = new AddUserRole(this,
                    namespace_,                    
                    roleId,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AddUserRole(AddUserRoleBuilder builder,
            string namespace_,
            string roleId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AddUserRole(
            string namespace_,            
            string roleId,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["roleId"] = roleId;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/roles/{roleId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json","text/plain" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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