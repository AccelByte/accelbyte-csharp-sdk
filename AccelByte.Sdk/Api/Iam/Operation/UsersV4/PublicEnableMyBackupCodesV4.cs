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
    /// PublicEnableMyBackupCodesV4
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
    public class PublicEnableMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicEnableMyBackupCodesV4Builder Builder = new PublicEnableMyBackupCodesV4Builder();

        public class PublicEnableMyBackupCodesV4Builder
            : OperationBuilder<PublicEnableMyBackupCodesV4Builder>
        {
            
            internal PublicEnableMyBackupCodesV4Builder() { }






            public PublicEnableMyBackupCodesV4 Build(
                string namespace_
            )
            {
                PublicEnableMyBackupCodesV4 op = new PublicEnableMyBackupCodesV4(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicEnableMyBackupCodesV4(PublicEnableMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicEnableMyBackupCodesV4(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode/enable";

        public override HttpMethod Method => HttpMethod.Post;

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