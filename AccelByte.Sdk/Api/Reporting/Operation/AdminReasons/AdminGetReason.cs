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
    /// adminGetReason
    ///
    /// This endpoint get a single reason.
    /// </summary>
    public class AdminGetReason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetReasonBuilder Builder { get => new AdminGetReasonBuilder(); }

        public class AdminGetReasonBuilder
            : OperationBuilder<AdminGetReasonBuilder>
        {





            internal AdminGetReasonBuilder() { }






            public AdminGetReason Build(
                string namespace_,
                string reasonId
            )
            {
                AdminGetReason op = new AdminGetReason(this,
                    namespace_,
                    reasonId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetReason(AdminGetReasonBuilder builder,
            string namespace_,
            string reasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetReason(
            string namespace_,
            string reasonId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["reasonId"] = reasonId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/reasons/{reasonId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RestapiAdminReasonResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RestapiAdminReasonResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RestapiAdminReasonResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiAdminReasonResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}