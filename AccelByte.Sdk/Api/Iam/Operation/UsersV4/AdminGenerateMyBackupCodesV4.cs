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
    /// AdminGenerateMyBackupCodesV4
    ///
    /// 
    /// 
    /// (In Development)This endpoint is used to generate 8-digits backup codes.
    /// Each code is a one-time code and will be deleted once used.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminGenerateMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateMyBackupCodesV4Builder Builder = new AdminGenerateMyBackupCodesV4Builder();

        public class AdminGenerateMyBackupCodesV4Builder
        {
            internal AdminGenerateMyBackupCodesV4Builder() { }





            public AdminGenerateMyBackupCodesV4 Build(
            )
            {
                return new AdminGenerateMyBackupCodesV4(this
                );
            }
        }

        private AdminGenerateMyBackupCodesV4(AdminGenerateMyBackupCodesV4Builder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public AdminGenerateMyBackupCodesV4(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCode";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelBackupCodesResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelBackupCodesResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelBackupCodesResponseV4>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}