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
    /// fulfillRewards
    ///
    ///  [SERVICE COMMUNICATION ONLY] Fulfill rewards.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:FULFILLMENT", action=1 (CREATED)
    ///   *  Returns : fulfillment result
    /// </summary>
    public class FulfillRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FulfillRewardsBuilder Builder = new FulfillRewardsBuilder();

        public class FulfillRewardsBuilder
        {
            
            
            public Model.RewardsRequest? Body { get; set; }
            
            internal FulfillRewardsBuilder() { }



            public FulfillRewardsBuilder SetBody(Model.RewardsRequest _body)
            {
                Body = _body;
                return this;
            }



            public FulfillRewards Build(
                string namespace_,
                string userId
            )
            {
                return new FulfillRewards(this,
                    namespace_,                    
                    userId                    
                );
            }
        }

        private FulfillRewards(FulfillRewardsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public FulfillRewards(
            string namespace_,            
            string userId,            
            Model.RewardsRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/fulfillment/rewards";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}