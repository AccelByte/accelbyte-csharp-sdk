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
    /// getUserVerificationCode
    ///
    /// [WARNING] This endpoint is only for testing purpose.
    /// This endpoint get active user verification
    /// code. There are 3 scenario of getting verification codes : after account registration, after reset password
    /// request, and after headless account upgrade. All of them will be returned on this endpoint. Required permission
    /// 'ADMIN:NAMESPACE:{namespace}:USER:{userId}:CODE' [READ]
    /// action code: 10146
    /// </summary>
    public class GetUserVerificationCode : AccelByte.Sdk.Core.Operation
    {
        public GetUserVerificationCode(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/codes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelVerificationCodeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelVerificationCodeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelVerificationCodeResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}