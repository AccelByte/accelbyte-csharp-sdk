// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// adminGetUserProgression
    ///
    /// 
    ///     * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE:PROGRESSION [READ]
    /// </summary>
    public class AdminGetUserProgression : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserProgressionBuilder Builder { get => new AdminGetUserProgressionBuilder(); }

        public class AdminGetUserProgressionBuilder
            : OperationBuilder<AdminGetUserProgressionBuilder>
        {

            public DateTime? DateTime { get; set; }

            public string? GoalCode { get; set; }

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public List<string>? Tags { get; set; }





            internal AdminGetUserProgressionBuilder() { }


            public AdminGetUserProgressionBuilder SetDateTime(DateTime _dateTime)
            {
                DateTime = _dateTime;
                return this;
            }

            public AdminGetUserProgressionBuilder SetGoalCode(string _goalCode)
            {
                GoalCode = _goalCode;
                return this;
            }

            public AdminGetUserProgressionBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetUserProgressionBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public AdminGetUserProgressionBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public AdminGetUserProgression Build(
                string challengeCode,
                string namespace_,
                string userId
            )
            {
                AdminGetUserProgression op = new AdminGetUserProgression(this,
                    challengeCode,
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

        private AdminGetUserProgression(AdminGetUserProgressionBuilder builder,
            string challengeCode,
            string namespace_,
            string userId
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.DateTime != null)
                QueryParams["dateTime"] = builder.DateTime.Value.ToString("O", System.Globalization.CultureInfo.InvariantCulture);
            if (builder.GoalCode is not null) QueryParams["goalCode"] = builder.GoalCode;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserProgression(
            string challengeCode,
            string namespace_,
            string userId,
            DateTime? dateTime,
            string? goalCode,
            long? limit,
            long? offset,
            List<string>? tags
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (dateTime != null)
                QueryParams["dateTime"] = dateTime.Value.ToString("O", System.Globalization.CultureInfo.InvariantCulture);
            if (goalCode is not null) QueryParams["goalCode"] = goalCode;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/users/{userId}/progress/{challengeCode}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUserProgressionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelUserProgressionResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelUserProgressionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserProgressionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}