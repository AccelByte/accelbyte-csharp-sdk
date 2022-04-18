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
    /// PublicDisableMyBackupCodesV4
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
    public class PublicDisableMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicDisableMyBackupCodesV4Builder Builder = new PublicDisableMyBackupCodesV4Builder();

        public class PublicDisableMyBackupCodesV4Builder
            : OperationBuilder<PublicDisableMyBackupCodesV4Builder>
        {
            
            internal PublicDisableMyBackupCodesV4Builder() { }





            public PublicDisableMyBackupCodesV4 Build(
                string namespace_
            )
            {
                PublicDisableMyBackupCodesV4 op = new PublicDisableMyBackupCodesV4(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicDisableMyBackupCodesV4(PublicDisableMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicDisableMyBackupCodesV4(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode/disable";

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