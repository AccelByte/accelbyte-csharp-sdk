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
    /// getUserSubscriptionActivities
    ///
    /// Get user subscription activity.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:USER:{userId}:SUBSCRIPTION", action=2 (READ)
    ///   *  Returns : paginated subscription activity
    /// </summary>
    public class GetUserSubscriptionActivities : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetUserSubscriptionActivitiesBuilder Builder = new GetUserSubscriptionActivitiesBuilder();

        public class GetUserSubscriptionActivitiesBuilder
            : OperationBuilder<GetUserSubscriptionActivitiesBuilder>
        {
            
            
            public bool? ExcludeSystem { get; set; }
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public string? SubscriptionId { get; set; }
            
            internal GetUserSubscriptionActivitiesBuilder() { }


            public GetUserSubscriptionActivitiesBuilder SetExcludeSystem(bool _excludeSystem)
            {
                ExcludeSystem = _excludeSystem;
                return this;
            }

            public GetUserSubscriptionActivitiesBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetUserSubscriptionActivitiesBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetUserSubscriptionActivitiesBuilder SetSubscriptionId(string _subscriptionId)
            {
                SubscriptionId = _subscriptionId;
                return this;
            }




            public GetUserSubscriptionActivities Build(
                string namespace_,
                string userId
            )
            {
                GetUserSubscriptionActivities op = new GetUserSubscriptionActivities(this,
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetUserSubscriptionActivities(GetUserSubscriptionActivitiesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (builder.ExcludeSystem != null) QueryParams["excludeSystem"] = Convert.ToString(builder.ExcludeSystem)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.SubscriptionId != null) QueryParams["subscriptionId"] = builder.SubscriptionId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetUserSubscriptionActivities(
            string namespace_,            
            string userId,            
            bool? excludeSystem,            
            int? limit,            
            int? offset,            
            string? subscriptionId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            if (excludeSystem != null) QueryParams["excludeSystem"] = Convert.ToString(excludeSystem)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (subscriptionId != null) QueryParams["subscriptionId"] = subscriptionId;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/subscriptions/activities";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.SubscriptionActivityPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionActivityPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.SubscriptionActivityPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}