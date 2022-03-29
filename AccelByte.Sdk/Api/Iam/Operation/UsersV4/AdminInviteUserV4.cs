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
    /// AdminInviteUserV4
    ///
    /// Required permission 'ADMIN:USER:INVITE [CREATE]
    /// 
    /// Use this endpoint to invite admin or non-admin user and assign role to them. The role must be scoped to namespace. An admin user can only
    /// assign role with namespaces that the admin user has required permission which is same as the required permission of endpoint: [AdminAddUserRoleV4].
    /// Role is optional, if not specified then it will only assign User role
    /// 
    /// The invited admin will also assigned with "User" role by default.
    /// </summary>
    public class AdminInviteUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminInviteUserV4Builder Builder = new AdminInviteUserV4Builder();

        public class AdminInviteUserV4Builder
        {
            
            internal AdminInviteUserV4Builder() { }





            public AdminInviteUserV4 Build(
                ModelInviteUserRequestV4 body
            )
            {
                return new AdminInviteUserV4(this,
                    body                    
                );
            }
        }

        private AdminInviteUserV4(AdminInviteUserV4Builder builder,
            ModelInviteUserRequestV4 body
        )
        {
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AdminInviteUserV4(
            Model.ModelInviteUserRequestV4 body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/iam/v4/admin/users/users/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelInviteUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}