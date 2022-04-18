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
    /// AdminDeleteUserPermissionBulkV3
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:PERMISSION:USER:{userId} [DELETE]'
    /// </summary>
    public class AdminDeleteUserPermissionBulkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserPermissionBulkV3Builder Builder = new AdminDeleteUserPermissionBulkV3Builder();

        public class AdminDeleteUserPermissionBulkV3Builder
            : OperationBuilder<AdminDeleteUserPermissionBulkV3Builder>
        {
            
            
            
            internal AdminDeleteUserPermissionBulkV3Builder() { }





            public AdminDeleteUserPermissionBulkV3 Build(
                List<ModelPermissionDeleteRequest> body,
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserPermissionBulkV3 op = new AdminDeleteUserPermissionBulkV3(this,
                    body,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteUserPermissionBulkV3(AdminDeleteUserPermissionBulkV3Builder builder,
            List<ModelPermissionDeleteRequest> body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteUserPermissionBulkV3(
            string namespace_,            
            string userId,            
            List<Model.ModelPermissionDeleteRequest> body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/permissions";

        public override HttpMethod Method => HttpMethod.Delete;

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