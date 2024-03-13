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
    /// adminRandomizeChallenge
    ///
    /// 
    ///   * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE [UPDATE]
    /// 
    /// This is a utility endpoint to execute randomize goals schedule on challenge that the assignmentRule is RANDOMIZED.
    /// </summary>
    public class AdminRandomizeChallenge : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminRandomizeChallengeBuilder Builder { get => new AdminRandomizeChallengeBuilder(); }

        public class AdminRandomizeChallengeBuilder
            : OperationBuilder<AdminRandomizeChallengeBuilder>
        {





            internal AdminRandomizeChallengeBuilder() { }






            public AdminRandomizeChallenge Build(
                string challengeCode,
                string namespace_
            )
            {
                AdminRandomizeChallenge op = new AdminRandomizeChallenge(this,
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

        private AdminRandomizeChallenge(AdminRandomizeChallengeBuilder builder,
            string challengeCode,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminRandomizeChallenge(
            string challengeCode,
            string namespace_
        )
        {
            PathParams["challengeCode"] = challengeCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/challenges/{challengeCode}/randomize";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelSchedule>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelSchedule>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelSchedule>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelSchedule>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}