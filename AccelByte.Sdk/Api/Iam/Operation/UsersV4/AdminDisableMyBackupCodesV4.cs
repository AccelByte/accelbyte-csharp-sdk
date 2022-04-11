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
    /// AdminDisableMyBackupCodesV4
    ///
    /// 
    /// 
    /// This endpoint is used to enable 2FA backup codes.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminDisableMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDisableMyBackupCodesV4Builder Builder = new AdminDisableMyBackupCodesV4Builder();

        public class AdminDisableMyBackupCodesV4Builder
        {
            internal AdminDisableMyBackupCodesV4Builder() { }





            public AdminDisableMyBackupCodesV4 Build(
            )
            {
                return new AdminDisableMyBackupCodesV4(this
                );
            }
        }

        private AdminDisableMyBackupCodesV4(AdminDisableMyBackupCodesV4Builder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public AdminDisableMyBackupCodesV4(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCode/disable";

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