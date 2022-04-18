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
    /// GetRoleMembers
    ///
    /// 
    /// 
    /// Required permission 'ROLE [READ]'
    /// 
    /// 
    /// 
    /// 
    /// Admin roles has its members listed in the role.
    /// </summary>
    public class GetRoleMembers : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRoleMembersBuilder Builder = new GetRoleMembersBuilder();

        public class GetRoleMembersBuilder
            : OperationBuilder<GetRoleMembersBuilder>
        {
            
            internal GetRoleMembersBuilder() { }





            public GetRoleMembers Build(
                string roleId
            )
            {
                GetRoleMembers op = new GetRoleMembers(this,
                    roleId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetRoleMembers(GetRoleMembersBuilder builder,
            string roleId
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetRoleMembers(
            string roleId            
        )
        {
            PathParams["roleId"] = roleId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/roles/{roleId}/members";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelRoleMembersResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleMembersResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleMembersResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}