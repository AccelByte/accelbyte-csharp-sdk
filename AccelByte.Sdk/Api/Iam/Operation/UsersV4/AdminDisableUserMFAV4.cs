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
    /// AdminDisableUserMFAV4
    ///
    /// 
    /// 
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:USER:{userId} [DELETE] permission
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to disable user 2FA.
    /// </summary>
    public class AdminDisableUserMFAV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDisableUserMFAV4Builder Builder = new AdminDisableUserMFAV4Builder();

        public class AdminDisableUserMFAV4Builder
        {
            
            
            internal AdminDisableUserMFAV4Builder() { }





            public AdminDisableUserMFAV4 Build(
                string namespace_,
                string userId
            )
            {
                return new AdminDisableUserMFAV4(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private AdminDisableUserMFAV4(AdminDisableUserMFAV4Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }
        #endregion

        public AdminDisableUserMFAV4(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/mfa/disable";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] {  };

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