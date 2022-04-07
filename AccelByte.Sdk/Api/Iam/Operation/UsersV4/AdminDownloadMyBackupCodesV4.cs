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
    /// AdminDownloadMyBackupCodesV4
    ///
    /// 
    /// 
    /// (In Development)This endpoint is used to download backup codes.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminDownloadMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDownloadMyBackupCodesV4Builder Builder = new AdminDownloadMyBackupCodesV4Builder();

        public class AdminDownloadMyBackupCodesV4Builder
        {
            internal AdminDownloadMyBackupCodesV4Builder() { }





            public AdminDownloadMyBackupCodesV4 Build(
            )
            {
                return new AdminDownloadMyBackupCodesV4(this
                );
            }
        }

        private AdminDownloadMyBackupCodesV4(AdminDownloadMyBackupCodesV4Builder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public AdminDownloadMyBackupCodesV4(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCode/download";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}