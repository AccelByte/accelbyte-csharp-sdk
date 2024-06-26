// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Cloudsave.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Cloudsave.Operation
{
    /// <summary>
    /// listMyBinaryRecordsV1
    ///
    /// Retrieve list of my binary records by namespace.
    /// </summary>
    public class ListMyBinaryRecordsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListMyBinaryRecordsV1Builder Builder { get => new ListMyBinaryRecordsV1Builder(); }

        public class ListMyBinaryRecordsV1Builder
            : OperationBuilder<ListMyBinaryRecordsV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Query { get; set; }

            public List<string>? Tags { get; set; }





            internal ListMyBinaryRecordsV1Builder() { }


            public ListMyBinaryRecordsV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public ListMyBinaryRecordsV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public ListMyBinaryRecordsV1Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }

            public ListMyBinaryRecordsV1Builder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public ListMyBinaryRecordsV1 Build(
                string namespace_
            )
            {
                ListMyBinaryRecordsV1 op = new ListMyBinaryRecordsV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private ListMyBinaryRecordsV1(ListMyBinaryRecordsV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Query is not null) QueryParams["query"] = builder.Query;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public ListMyBinaryRecordsV1(
            string namespace_,
            long? limit,
            long? offset,
            string? query,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (query is not null) QueryParams["query"] = query;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/me/binaries";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsListPlayerBinaryRecordsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsListPlayerBinaryRecordsResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsListPlayerBinaryRecordsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerBinaryRecordsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}