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
    /// GetUserPlatformAccounts
    ///
    /// 
    /// 
    /// 
    /// Required permission 'NAMESPACE:{namespace}:USER:{userId} [READ]'.
    /// 
    /// 
    /// 
    /// 
    /// ## Justice Platform Account
    /// 
    /// 
    /// 
    /// 
    /// The permission âADMIN:NAMESPACE:{namespace}:JUSTICE:USER:{userId}â [READ] is required in order to read the UserID who linked with the user.
    /// </summary>
    public class GetUserPlatformAccounts : AccelByte.Sdk.Core.Operation
    {
        public GetUserPlatformAccounts(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            
        }

        public override string Path => "/iam/namespaces/{namespace}/users/{userId}/platforms";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.AccountcommonUserLinkedPlatform>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.AccountcommonUserLinkedPlatform>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.AccountcommonUserLinkedPlatform>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}