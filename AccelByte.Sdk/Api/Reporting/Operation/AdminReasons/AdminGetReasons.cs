// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// adminGetReasons
    ///
    /// This endpoint get reasons with pagination
    /// </summary>
    public class AdminGetReasons : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetReasonsBuilder Builder { get => new AdminGetReasonsBuilder(); }

        public class AdminGetReasonsBuilder
            : OperationBuilder<AdminGetReasonsBuilder>
        {

            public string? Group { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public string? Title { get; set; }





            internal AdminGetReasonsBuilder() { }


            public AdminGetReasonsBuilder SetGroup(string _group)
            {
                Group = _group;
                return this;
            }

            public AdminGetReasonsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetReasonsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetReasonsBuilder SetTitle(string _title)
            {
                Title = _title;
                return this;
            }





            public AdminGetReasons Build(
                string namespace_
            )
            {
                AdminGetReasons op = new AdminGetReasons(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetReasons(AdminGetReasonsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Group is not null) QueryParams["group"] = builder.Group;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Title is not null) QueryParams["title"] = builder.Title;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetReasons(
            string namespace_,
            string? group,
            long? limit,
            long? offset,
            string? title
        )
        {
            PathParams["namespace"] = namespace_;

            if (group is not null) QueryParams["group"] = group;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (title is not null) QueryParams["title"] = title;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RestapiAdminReasonListResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RestapiAdminReasonListResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RestapiAdminReasonListResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiAdminReasonListResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}