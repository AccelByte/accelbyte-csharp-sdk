// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// publicBulkClaimUserRewards
    ///
    /// This API is used to bulk claim all remained rewards, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:SEASONPASS", action=4 (UPDATE)
    ///   *  Returns : user season data
    /// </summary>
    public class PublicBulkClaimUserRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicBulkClaimUserRewardsBuilder Builder = new PublicBulkClaimUserRewardsBuilder();

        public class PublicBulkClaimUserRewardsBuilder
            : OperationBuilder<PublicBulkClaimUserRewardsBuilder>
        {





            internal PublicBulkClaimUserRewardsBuilder() { }






            public PublicBulkClaimUserRewards Build(
                string namespace_,
                string userId
            )
            {
                PublicBulkClaimUserRewards op = new PublicBulkClaimUserRewards(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicBulkClaimUserRewards(PublicBulkClaimUserRewardsBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicBulkClaimUserRewards(
            string namespace_,            
            string userId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/public/namespaces/{namespace}/users/{userId}/seasons/current/rewards/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] {  };

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