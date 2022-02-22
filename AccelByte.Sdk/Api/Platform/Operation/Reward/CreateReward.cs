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
    /// createReward
    ///
    /// This API is used to create a reward.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:REWARD", action=1 (CREATE)
    ///   *  Returns : created reward data
    /// </summary>
    public class CreateReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateRewardBuilder Builder = new CreateRewardBuilder();

        public class CreateRewardBuilder
        {
            
            public Model.RewardCreate? Body { get; set; }
            
            internal CreateRewardBuilder() { }



            public CreateRewardBuilder SetBody(Model.RewardCreate _body)
            {
                Body = _body;
                return this;
            }



            public CreateReward Build(
                string namespace_
            )
            {
                return new CreateReward(this,
                    namespace_                    
                );
            }
        }

        private CreateReward(CreateRewardBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreateReward(
            string namespace_,            
            Model.RewardCreate body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

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