// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dslogmanager.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dslogmanager.Operation
{
    /// <summary>
    /// getServerLogs
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:DSM:SERVER [READ]
    /// 
    /// Required scope: social
    /// 
    /// This endpoint queries a specified dedicated server's logs.
    /// </summary>
    public class GetServerLogs : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetServerLogsBuilder Builder { get => new GetServerLogsBuilder(); }

        public class GetServerLogsBuilder
            : OperationBuilder<GetServerLogsBuilder>
        {

            public string? LogType { get; set; }

            public long? Offset { get; set; }

            public string? Origin { get; set; }





            internal GetServerLogsBuilder() { }


            public GetServerLogsBuilder SetLogType(string _logType)
            {
                LogType = _logType;
                return this;
            }

            public GetServerLogsBuilder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }

            public GetServerLogsBuilder SetOrigin(string _origin)
            {
                Origin = _origin;
                return this;
            }





            public GetServerLogs Build(
                string namespace_,
                string podName
            )
            {
                GetServerLogs op = new GetServerLogs(this,
                    namespace_,
                    podName
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GetServerLogs(GetServerLogsBuilder builder,
            string namespace_,
            string podName
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;

            if (builder.LogType is not null) QueryParams["logType"] = builder.LogType;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            if (builder.Origin is not null) QueryParams["origin"] = builder.Origin;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetServerLogs(
            string namespace_,
            string podName,
            string? logType,
            long? offset,
            string? origin
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;

            if (logType is not null) QueryParams["logType"] = logType;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            if (origin is not null) QueryParams["origin"] = origin;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/dslogmanager/admin/namespaces/{namespace}/servers/{podName}/logs";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsServerLogs? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsServerLogs>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsServerLogs>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsServerLogs>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}