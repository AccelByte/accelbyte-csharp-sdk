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
    /// AdminGetMyBackupCodesV4
    ///
    /// 
    /// 
    /// This endpoint is used to get 8-digits backup codes.
    /// Each code is a one-time code and will be deleted once used.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminGetMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetMyBackupCodesV4Builder Builder = new AdminGetMyBackupCodesV4Builder();

        public class AdminGetMyBackupCodesV4Builder
            : OperationBuilder<AdminGetMyBackupCodesV4Builder>
        {
            internal AdminGetMyBackupCodesV4Builder() { }






            public AdminGetMyBackupCodesV4 Build(
            )
            {
                AdminGetMyBackupCodesV4 op = new AdminGetMyBackupCodesV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetMyBackupCodesV4(AdminGetMyBackupCodesV4Builder builder
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetMyBackupCodesV4(
        )
        {
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCode";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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