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
    /// queryRewards
    ///
    /// This API is used to query rewards for a season.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=2 (READ)
    ///   *  Returns : the list of rewards
    /// </summary>
    public class QueryRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryRewardsBuilder Builder = new QueryRewardsBuilder();

        public class QueryRewardsBuilder
        {
            
            
            public string? Q { get; set; }
            
            internal QueryRewardsBuilder() { }


            public QueryRewardsBuilder SetQ(string _q)
            {
                Q = _q;
                return this;
            }




            public QueryRewards Build(
                string namespace_,
                string seasonId
            )
            {
                return new QueryRewards(this,
                    namespace_,                    
                    seasonId                    
                );
            }
        }

        private QueryRewards(QueryRewardsBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            if (builder.Q != null) QueryParams["q"] = builder.Q;
            
            
            
            
        }
        #endregion

        public QueryRewards(
            string namespace_,            
            string seasonId,            
            string? q            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            if (q != null) QueryParams["q"] = q;
            
            
            
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/rewards";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.RewardInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RewardInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RewardInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}