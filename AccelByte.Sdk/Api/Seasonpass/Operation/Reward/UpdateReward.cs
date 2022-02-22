// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// updateReward
    ///
    /// This API is used to update a reward. Only draft season reward can be updated.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : updated reward
    /// </summary>
    public class UpdateReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRewardBuilder Builder = new UpdateRewardBuilder();

        public class UpdateRewardBuilder
        {
            
            
            
            public Model.RewardUpdate? Body { get; set; }
            
            internal UpdateRewardBuilder() { }



            public UpdateRewardBuilder SetBody(Model.RewardUpdate _body)
            {
                Body = _body;
                return this;
            }



            public UpdateReward Build(
                string code,
                string namespace_,
                string seasonId
            )
            {
                return new UpdateReward(this,
                    code,                    
                    namespace_,                    
                    seasonId                    
                );
            }
        }

        private UpdateReward(UpdateRewardBuilder builder,
            string code,
            string namespace_,
            string seasonId
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdateReward(
            string code,            
            string namespace_,            
            string seasonId,            
            Model.RewardUpdate body            
        )
        {
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards/{code}";

        public override HttpMethod Method => HttpMethod.Patch;

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