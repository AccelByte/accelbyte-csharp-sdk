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
    /// publicListSchedulesByGoal
    ///
    /// 
    /// 
    ///   * Required permission: NAMESPACE:{namespace}:CHALLENGE [READ]
    /// 
    /// List schedules of given goal in a challenge for specific user.
    /// </summary>
    public class PublicListSchedulesByGoal : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicListSchedulesByGoalBuilder Builder { get => new PublicListSchedulesByGoalBuilder(); }

        public class PublicListSchedulesByGoalBuilder
            : OperationBuilder<PublicListSchedulesByGoalBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal PublicListSchedulesByGoalBuilder() { }


            public PublicListSchedulesByGoalBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public PublicListSchedulesByGoalBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public PublicListSchedulesByGoal Build(
                string challengeCode,
                string code,
                string namespace_
            )
            {
                PublicListSchedulesByGoal op = new PublicListSchedulesByGoal(this,
                    challengeCode,
                    code,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicListSchedulesByGoal(PublicListSchedulesByGoalBuilder builder,
            string challengeCode,
            string code,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicListSchedulesByGoal(
            string challengeCode,
            string code,
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["code"] = code;
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/public/namespaces/{namespace}/challenges/{challengeCode}/goals/{code}/schedules";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelListScheduleByGoalResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelListScheduleByGoalResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelListScheduleByGoalResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelListScheduleByGoalResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}