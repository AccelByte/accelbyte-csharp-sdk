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
    /// getReward
    ///
    /// This API is used to get reward by reward Id.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=2 (READ)
    ///   *  Returns : reward instance
    /// </summary>
    public class GetReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRewardBuilder Builder = new GetRewardBuilder();

        public class GetRewardBuilder
            : OperationBuilder<GetRewardBuilder>
        {
            
            
            internal GetRewardBuilder() { }





            public GetReward Build(
                string namespace_,
                string rewardId
            )
            {
                GetReward op = new GetReward(this,
                    namespace_,                    
                    rewardId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetReward(GetRewardBuilder builder,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetReward(
            string namespace_,            
            string rewardId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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