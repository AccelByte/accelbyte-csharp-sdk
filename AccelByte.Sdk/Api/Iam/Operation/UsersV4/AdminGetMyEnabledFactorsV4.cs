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
    /// AdminGetMyEnabledFactorsV4
    ///
    /// 
    /// 
    /// This endpoint is used to get user enabled factors.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class AdminGetMyEnabledFactorsV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetMyEnabledFactorsV4Builder Builder = new AdminGetMyEnabledFactorsV4Builder();

        public class AdminGetMyEnabledFactorsV4Builder
        {
            internal AdminGetMyEnabledFactorsV4Builder() { }





            public AdminGetMyEnabledFactorsV4 Build(
            )
            {
                return new AdminGetMyEnabledFactorsV4(this
                );
            }
        }

        private AdminGetMyEnabledFactorsV4(AdminGetMyEnabledFactorsV4Builder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public AdminGetMyEnabledFactorsV4(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/factor";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelEnabledFactorsResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelEnabledFactorsResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelEnabledFactorsResponseV4>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}