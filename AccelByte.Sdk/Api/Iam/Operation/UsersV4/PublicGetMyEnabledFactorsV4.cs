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
    /// PublicGetMyEnabledFactorsV4
    ///
    /// 
    /// 
    /// (In Development)This endpoint is used to get user enabled factors.
    /// 
    /// 
    /// 
    /// 
    /// This endpoint Requires valid user access token
    /// </summary>
    public class PublicGetMyEnabledFactorsV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyEnabledFactorsV4Builder Builder = new PublicGetMyEnabledFactorsV4Builder();

        public class PublicGetMyEnabledFactorsV4Builder
        {
            
            internal PublicGetMyEnabledFactorsV4Builder() { }





            public PublicGetMyEnabledFactorsV4 Build(
                string namespace_
            )
            {
                return new PublicGetMyEnabledFactorsV4(this,
                    namespace_                    
                );
            }
        }

        private PublicGetMyEnabledFactorsV4(PublicGetMyEnabledFactorsV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public PublicGetMyEnabledFactorsV4(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/factor";

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