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
    /// RetrievePlayerRecords
    ///
    /// Retrieve list of player records key under given namespace.
    /// </summary>
    public class RetrievePlayerRecords : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrievePlayerRecordsBuilder Builder { get => new RetrievePlayerRecordsBuilder(); }

        public class RetrievePlayerRecordsBuilder
            : OperationBuilder<RetrievePlayerRecordsBuilder>
        {

            public long? Limit { get; set; }

            public long? Offset { get; set; }





            internal RetrievePlayerRecordsBuilder() { }


            public RetrievePlayerRecordsBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public RetrievePlayerRecordsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public RetrievePlayerRecords Build(
                string namespace_
            )
            {
                RetrievePlayerRecords op = new RetrievePlayerRecords(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RetrievePlayerRecords(RetrievePlayerRecordsBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RetrievePlayerRecords(
            string namespace_,
            long? limit,
            long? offset
        )
        {
            PathParams["namespace"] = namespace_;

            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/cloudsave/v1/namespaces/{namespace}/users/me/records";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsListPlayerRecordKeysResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsListPlayerRecordKeysResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}