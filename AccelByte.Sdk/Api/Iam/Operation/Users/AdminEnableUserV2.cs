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
    /// AdminEnableUserV2
    ///
    /// Required permissions 'ADMIN:NAMESPACE:{namespace}:USERSTATUS:USER:{userId} [UPDATE]'
    /// </summary>
    public class AdminEnableUserV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminEnableUserV2Builder Builder = new AdminEnableUserV2Builder();

        public class AdminEnableUserV2Builder
            : OperationBuilder<AdminEnableUserV2Builder>
        {
            
            
            internal AdminEnableUserV2Builder() { }





            public AdminEnableUserV2 Build(
                string namespace_,
                string userId
            )
            {
                AdminEnableUserV2 op = new AdminEnableUserV2(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminEnableUserV2(AdminEnableUserV2Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminEnableUserV2(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users/{userId}/enable";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "*/*" };

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