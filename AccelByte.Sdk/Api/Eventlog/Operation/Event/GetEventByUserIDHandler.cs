// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Eventlog.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Eventlog.Operation
{
    /// <summary>
    /// GetEventByUserIDHandler
    ///
    /// Required permission `NAMESPACE:{namespace}:EVENT [UPDATE]` and scope `analytics`
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class GetEventByUserIDHandler : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetEventByUserIDHandlerBuilder Builder { get => new GetEventByUserIDHandlerBuilder(); }

        public class GetEventByUserIDHandlerBuilder
            : OperationBuilder<GetEventByUserIDHandlerBuilder>
        {

            public long? Offset { get; set; }





            internal GetEventByUserIDHandlerBuilder() { }


            public GetEventByUserIDHandlerBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetEventByUserIDHandler Build(
                string namespace_,
                string userId,
                string endDate,
                long pageSize,
                string startDate
            )
            {
                GetEventByUserIDHandler op = new GetEventByUserIDHandler(this,
                    namespace_,
                    userId,
                    endDate,
                    pageSize,
                    startDate
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetEventByUserIDHandler(GetEventByUserIDHandlerBuilder builder,
            string namespace_,
            string userId,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;

            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetEventByUserIDHandler(
            string namespace_,
            string userId,
            long? offset,
            string endDate,
            long pageSize,
            string startDate
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (endDate is not null) QueryParams["endDate"] = endDate;

            QueryParams["pageSize"] = Convert.ToString(pageSize)!;
            if (startDate is not null) QueryParams["startDate"] = startDate;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/event/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsEventResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsEventResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}