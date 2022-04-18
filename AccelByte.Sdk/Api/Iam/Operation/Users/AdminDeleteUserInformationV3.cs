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
    /// AdminDeleteUserInformationV3
    ///
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:INFORMATION:USER:{userId} [DELETE]'.
    /// </summary>
    public class AdminDeleteUserInformationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteUserInformationV3Builder Builder = new AdminDeleteUserInformationV3Builder();

        public class AdminDeleteUserInformationV3Builder
            : OperationBuilder<AdminDeleteUserInformationV3Builder>
        {
            
            
            internal AdminDeleteUserInformationV3Builder() { }





            public AdminDeleteUserInformationV3 Build(
                string namespace_,
                string userId
            )
            {
                AdminDeleteUserInformationV3 op = new AdminDeleteUserInformationV3(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminDeleteUserInformationV3(AdminDeleteUserInformationV3Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteUserInformationV3(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/information";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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