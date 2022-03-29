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
    /// PublicGenerateMyBackupCodesV4
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
    public class PublicGenerateMyBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGenerateMyBackupCodesV4Builder Builder = new PublicGenerateMyBackupCodesV4Builder();

        public class PublicGenerateMyBackupCodesV4Builder
        {
            
            internal PublicGenerateMyBackupCodesV4Builder() { }





            public PublicGenerateMyBackupCodesV4 Build(
                string namespace_
            )
            {
                return new PublicGenerateMyBackupCodesV4(this,
                    namespace_                    
                );
            }
        }

        private PublicGenerateMyBackupCodesV4(PublicGenerateMyBackupCodesV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public PublicGenerateMyBackupCodesV4(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/backupCode";

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