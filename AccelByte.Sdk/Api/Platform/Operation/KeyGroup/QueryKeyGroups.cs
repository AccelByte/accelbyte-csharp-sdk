// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// queryKeyGroups
    ///
    /// Query key groups, if name is presented, it's fuzzy match.
    /// Other detail info:
    /// 
    ///   * Required permission : resource="ADMIN:NAMESPACE:{namespace}:KEYGROUP", action=2 (READ)
    ///   *  Returns : slice of key group
    /// </summary>
    public class QueryKeyGroups : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static QueryKeyGroupsBuilder Builder { get => new QueryKeyGroupsBuilder(); }

        public class QueryKeyGroupsBuilder
            : OperationBuilder<QueryKeyGroupsBuilder>
        {

            public int? Limit { get; set; }

            public string? Name { get; set; }

            public int? Offset { get; set; }

            public string? Tag { get; set; }





            internal QueryKeyGroupsBuilder() { }


            public QueryKeyGroupsBuilder SetLimit(int _limit)
            {
                Limit = _limit;
                return this;
            }

            public QueryKeyGroupsBuilder SetName(string _name)
            {
                Name = _name;
                return this;
            }

            public QueryKeyGroupsBuilder SetOffset(int _offset)
            {
                Offset = _offset;
                return this;
            }

            public QueryKeyGroupsBuilder SetTag(string _tag)
            {
                Tag = _tag;
                return this;
            }





            public QueryKeyGroups Build(
                string namespace_
            )
            {
                QueryKeyGroups op = new QueryKeyGroups(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private QueryKeyGroups(QueryKeyGroupsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Name is not null) QueryParams["name"] = builder.Name;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Tag is not null) QueryParams["tag"] = builder.Tag;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public QueryKeyGroups(
            string namespace_,
            int? limit,
            string? name,
            int? offset,
            string? tag
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (name is not null) QueryParams["name"] = name;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (tag is not null) QueryParams["tag"] = tag;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/keygroups";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.KeyGroupPagingSlicedResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.KeyGroupPagingSlicedResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.KeyGroupPagingSlicedResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.KeyGroupPagingSlicedResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}