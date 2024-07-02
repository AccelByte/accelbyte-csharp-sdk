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
    /// publicGetScheduledGoals
    ///
    /// 
    ///     * Required permission: NAMESPACE:{namespace}:CHALLENGE [READ]
    /// </summary>
    public class PublicGetScheduledGoals : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetScheduledGoalsBuilder Builder { get => new PublicGetScheduledGoalsBuilder(); }

        public class PublicGetScheduledGoalsBuilder
            : OperationBuilder<PublicGetScheduledGoalsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }

            public List<string>? Tags { get; set; }





            internal PublicGetScheduledGoalsBuilder() { }


            public PublicGetScheduledGoalsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicGetScheduledGoalsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public PublicGetScheduledGoalsBuilder SetTags(List<string> _tags)
            {
                Tags = _tags;
                return this;
            }





            public PublicGetScheduledGoals Build(
                string challengeCode,
                string namespace_
            )
            {
                PublicGetScheduledGoals op = new PublicGetScheduledGoals(this,
                    challengeCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetScheduledGoals(PublicGetScheduledGoalsBuilder builder,
            string challengeCode,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Tags is not null) QueryParams["tags"] = builder.Tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetScheduledGoals(
            string challengeCode,
            string namespace_,
            long? limit,
            long? offset,
            List<string>? tags
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (tags is not null) QueryParams["tags"] = tags;



            CollectionFormatMap["tags"] = "csv";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/public/namespaces/{namespace}/challenges/{challengeCode}/goals";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelGetGoalsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelGetGoalsResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelGetGoalsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetGoalsResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}