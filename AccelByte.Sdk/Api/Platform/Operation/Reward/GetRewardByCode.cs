// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// getRewardByCode
    ///
    /// This API is used to get reward by reward code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : reward instance
    /// </summary>
    public class GetRewardByCode : AccelByte.Sdk.Core.Operation
    {
        public GetRewardByCode(
            string namespace_,            
            string rewardCode            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (rewardCode != null) QueryParams["rewardCode"] = rewardCode;
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/rewards/byCode";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.RewardInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RewardInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}