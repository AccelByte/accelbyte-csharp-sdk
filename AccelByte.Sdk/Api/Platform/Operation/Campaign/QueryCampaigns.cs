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
    /// queryCampaigns
    ///
    /// Query campaigns, if name is presented, it's fuzzy match.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:CAMPAIGN", action=2 (READ) (READ)
    ///   *  Returns : slice of campaigns
    /// </summary>
    public class QueryCampaigns : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryCampaignsBuilder Builder = new QueryCampaignsBuilder();

        public class QueryCampaignsBuilder
        {
            
            public int? Limit { get; set; }
            
            public string? Name { get; set; }
            
            public int? Offset { get; set; }
            
            public string? Tag { get; set; }
            
            internal QueryCampaignsBuilder() { }


            public QueryCampaignsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryCampaignsBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public QueryCampaignsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryCampaignsBuilder SetTag(string _tag)
            {
                Tag = _tag;
                return this;
            }




            public QueryCampaigns Build(
                string namespace_
            )
            {
                return new QueryCampaigns(this,
                    namespace_                    
                );
            }
        }

        private QueryCampaigns(QueryCampaignsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name != null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Tag != null) QueryParams["tag"] = builder.Tag;
            
            
            
            
        }
        #endregion

        public QueryCampaigns(
            string namespace_,            
            int? limit,            
            string? name,            
            int? offset,            
            string? tag            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name != null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (tag != null) QueryParams["tag"] = tag;
            
            
            
            
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/campaigns";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CampaignPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CampaignPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CampaignPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}