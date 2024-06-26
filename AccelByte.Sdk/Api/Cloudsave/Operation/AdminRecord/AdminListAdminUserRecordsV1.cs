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
    /// adminListAdminUserRecordsV1
    ///
    /// Retrieve list of admin player records key and userID under given namespace.
    /// </summary>
    public class AdminListAdminUserRecordsV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListAdminUserRecordsV1Builder Builder { get => new AdminListAdminUserRecordsV1Builder(); }

        public class AdminListAdminUserRecordsV1Builder
            : OperationBuilder<AdminListAdminUserRecordsV1Builder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Query { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminListAdminUserRecordsV1Builder() { }


            public AdminListAdminUserRecordsV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListAdminUserRecordsV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminListAdminUserRecordsV1Builder SetQuery(string _query)
            {
                Query = _query;
                return this;
            }

            public AdminListAdminUserRecordsV1Builder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminListAdminUserRecordsV1 Build(
                string namespace_,
                string userId
            )
            {
                AdminListAdminUserRecordsV1 op = new AdminListAdminUserRecordsV1(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminListAdminUserRecordsV1(AdminListAdminUserRecordsV1Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Query is not null) QueryParams["query"] = builder.Query;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListAdminUserRecordsV1(
            string namespace_,
            string userId,
            long? limit,
            long? offset,
            string? query,
            List<string>? tags
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (query is not null) QueryParams["query"] = query;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/admin/namespaces/{namespace}/users/{userId}/adminrecords";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsListAdminPlayerRecordKeysResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsListAdminPlayerRecordKeysResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsListAdminPlayerRecordKeysResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListAdminPlayerRecordKeysResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}