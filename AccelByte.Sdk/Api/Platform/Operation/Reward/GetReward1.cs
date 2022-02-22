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
    /// getReward_1
    ///
    /// This API is used to get reward by reward Id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : reward instance
    /// </summary>
    public class GetReward1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetReward1Builder Builder = new GetReward1Builder();

        public class GetReward1Builder
        {
            
            
            internal GetReward1Builder() { }





            public GetReward1 Build(
                string namespace_,
                string rewardId
            )
            {
                return new GetReward1(this,
                    namespace_,                    
                    rewardId                    
                );
            }
        }

        private GetReward1(GetReward1Builder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            
            
            
            
        }
        #endregion

        public GetReward1(
            string namespace_,            
            string rewardId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            
            
            
            
        }

        public override string Path => "/platform/public/namespaces/{namespace}/rewards/{rewardId}";

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