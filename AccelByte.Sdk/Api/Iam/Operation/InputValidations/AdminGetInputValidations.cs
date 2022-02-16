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
    /// AdminGetInputValidations
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:CONFIGURATION'[READ]
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is to get list of input validation configuration.
    /// 
    /// 
    /// 
    /// 
    /// `regex` parameter will be returned if `isCustomRegex` is true. Otherwise, it will be empty.
    /// </summary>
    public class AdminGetInputValidations : AccelByte.Sdk.Core.Operation
    {
        public AdminGetInputValidations(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/inputValidations";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelInputValidationsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}