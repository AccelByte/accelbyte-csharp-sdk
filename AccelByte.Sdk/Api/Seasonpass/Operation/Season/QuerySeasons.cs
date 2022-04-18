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
    /// querySeasons
    ///
    /// This API is used to query seasons, seasons only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:SEASONPASS", action=2 (READ)
    ///   *  Returns : the list of season basic info
    /// </summary>
    public class QuerySeasons : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QuerySeasonsBuilder Builder = new QuerySeasonsBuilder();

        public class QuerySeasonsBuilder
            : OperationBuilder<QuerySeasonsBuilder>
        {
            
            public int? Limit { get; set; }
            
            public int? Offset { get; set; }
            
            public List<string>? Status { get; set; }
            
            internal QuerySeasonsBuilder() { }


            public QuerySeasonsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QuerySeasonsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QuerySeasonsBuilder SetStatus(List<string> _status)
            {
                Status = _status;
                return this;
            }




            public QuerySeasons Build(
                string namespace_
            )
            {
                QuerySeasons op = new QuerySeasons(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private QuerySeasons(QuerySeasonsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Status != null) QueryParams["status"] = builder.Status;
            
            
            CollectionFormatMap["status"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QuerySeasons(
            string namespace_,            
            int? limit,            
            int? offset,            
            List<string>? status            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (status != null) QueryParams["status"] = status;
            
            
            CollectionFormatMap["status"] = "multi";
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/seasonpass/admin/namespaces/{namespace}/seasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ListSeasonInfoPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ListSeasonInfoPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ListSeasonInfoPagingSlicedResult>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}