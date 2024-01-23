// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// createStatCycle
    ///
    /// Create stat cycle.
    /// Fields:
    ///         * name: Cycle name, maximum length is 128 characters. (required).
    ///         * resetTime: Reset time must follow hours:minutes in 24 hours format e.g. 01:30, 23:15. (required)
    ///         * resetDay: Reset Day follows the ISO-8601 standard, from 1 (Monday) to 7 (Sunday). Required when cycleType is WEEKLY.
    ///         * resetDate: Reset Date must be a number 1 - 31. Required when cycleType is MONTHLY or ANNUALLY.
    ///         * resetMonth: Reset Month must be a number 1 - 12. Required when cycleType is ANNUALLY.
    ///         * seasonPeriod: Season period must be a number greater than or equal to 1 (days). Required when cycleType is SEASONAL.
    ///         * start: Start time must follow RFC3339 standard. e.g. 2023-02-24T05:10:24.865Z. (required)
    ///         * end: End time must follow RFC3339 standard. e.g. 2023-02-24T05:10:24.865Z.
    /// Other detail info:
    ///         *  Required permission : resource="ADMIN:NAMESPACE:{namespace}:STAT", action=1 (CREATE)
    ///         *  Returns : created stat cycle
    /// </summary>
    public class CreateStatCycle : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateStatCycleBuilder Builder { get => new CreateStatCycleBuilder(); }

        public class CreateStatCycleBuilder
            : OperationBuilder<CreateStatCycleBuilder>
        {


            public Model.StatCycleCreate? Body { get; set; }




            internal CreateStatCycleBuilder() { }



            public CreateStatCycleBuilder SetBody(Model.StatCycleCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateStatCycle Build(
                string namespace_
            )
            {
                CreateStatCycle op = new CreateStatCycle(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateStatCycle(CreateStatCycleBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateStatCycle(
            string namespace_,
            Model.StatCycleCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/admin/namespaces/{namespace}/statCycles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.StatCycleInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.StatCycleInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}