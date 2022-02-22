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
    /// queryPasses
    ///
    /// This API is used to query all passes for a season.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=2 (READ)
    ///   *  Returns : the list of passes
    /// </summary>
    public class QueryPasses : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryPassesBuilder Builder = new QueryPassesBuilder();

        public class QueryPassesBuilder
        {
            
            
            internal QueryPassesBuilder() { }





            public QueryPasses Build(
                string namespace_,
                string seasonId
            )
            {
                return new QueryPasses(this,
                    namespace_,                    
                    seasonId                    
                );
            }
        }

        private QueryPasses(QueryPassesBuilder builder,
            string namespace_,
            string seasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            
        }
        #endregion

        public QueryPasses(
            string namespace_,            
            string seasonId            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["seasonId"] = seasonId;
            
            
            
            
            
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons/{seasonId}/passes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.PassInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.PassInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.PassInfo>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}