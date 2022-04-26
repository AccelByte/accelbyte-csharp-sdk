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
    /// publicClaimUserReward
    ///
    /// This API is used to claim reward, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : user season data
    /// </summary>
    public class PublicClaimUserReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicClaimUserRewardBuilder Builder = new PublicClaimUserRewardBuilder();

        public class PublicClaimUserRewardBuilder
            : OperationBuilder<PublicClaimUserRewardBuilder>
        {
            
            
            public Model.UserRewardClaim? Body { get; set; }
            
            internal PublicClaimUserRewardBuilder() { }



            public PublicClaimUserRewardBuilder SetBody(Model.UserRewardClaim _body)
            {
                Body = _body;
                return this;
            }




            public PublicClaimUserReward Build(
                string namespace_,
                string userId
            )
            {
                PublicClaimUserReward op = new PublicClaimUserReward(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicClaimUserReward(PublicClaimUserRewardBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = builder.Body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicClaimUserReward(
            string namespace_,            
            string userId,            
            Model.UserRewardClaim body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ClaimableRewards? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ClaimableRewards>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ClaimableRewards>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}