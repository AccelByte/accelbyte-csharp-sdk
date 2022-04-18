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
    /// SetRoleAsAdmin
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
    /// Admin roles has its members listed in the role.
    /// 
    /// 
    /// 
    /// 
    /// Role can be set as admin role only when it has at least 1 manager.
    /// </summary>
    public class SetRoleAsAdmin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SetRoleAsAdminBuilder Builder = new SetRoleAsAdminBuilder();

        public class SetRoleAsAdminBuilder
            : OperationBuilder<SetRoleAsAdminBuilder>
        {
            
            internal SetRoleAsAdminBuilder() { }





            public SetRoleAsAdmin Build(
                string roleId
            )
            {
                SetRoleAsAdmin op = new SetRoleAsAdmin(this,
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private SetRoleAsAdmin(SetRoleAsAdminBuilder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SetRoleAsAdmin(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/admin";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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