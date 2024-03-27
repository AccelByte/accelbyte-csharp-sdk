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
    /// adminListGameBinaryRecordsV1
    ///
    /// Retrieve list of binary records by namespace.
    /// </summary>
    public class AdminListGameBinaryRecordsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListGameBinaryRecordsV1Builder Builder { get => new AdminListGameBinaryRecordsV1Builder(); }

        public class AdminListGameBinaryRecordsV1Builder
            : OperationBuilder<AdminListGameBinaryRecordsV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Query { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListGameBinaryRecordsV1Builder() { }


            public AdminListGameBinaryRecordsV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListGameBinaryRecordsV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListGameBinaryRecordsV1Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }

            public AdminListGameBinaryRecordsV1Builder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListGameBinaryRecordsV1 Build(
                string namespace_
            )
            {
                AdminListGameBinaryRecordsV1 op = new AdminListGameBinaryRecordsV1(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminListGameBinaryRecordsV1(AdminListGameBinaryRecordsV1Builder builder,
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

        public AdminListGameBinaryRecordsV1(
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

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/binaries";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsListGameBinaryRecordsAdminResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsListGameBinaryRecordsAdminResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsListGameBinaryRecordsAdminResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListGameBinaryRecordsAdminResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}