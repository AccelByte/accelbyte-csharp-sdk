// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGenerateReportV4
    ///
    /// This is the endpoint for an admin to generate device report
    /// </summary>
    public class AdminGenerateReportV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateReportV4Builder Builder { get => new AdminGenerateReportV4Builder(); }

        public class AdminGenerateReportV4Builder
            : OperationBuilder<AdminGenerateReportV4Builder>
        {

            public string? EndDate { get; set; }

            public string? StartDate { get; set; }





            internal AdminGenerateReportV4Builder() { }


            public AdminGenerateReportV4Builder SetEndDate(string _endDate)
            {
                EndDate = _endDate;
                return this;
            }

            public AdminGenerateReportV4Builder SetStartDate(string _startDate)
            {
                StartDate = _startDate;
                return this;
            }





            public AdminGenerateReportV4 Build(
                string namespace_,
                string deviceType
            )
            {
                AdminGenerateReportV4 op = new AdminGenerateReportV4(this,
                    namespace_,
                    deviceType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGenerateReportV4(AdminGenerateReportV4Builder builder,
            string namespace_,
            string deviceType
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.EndDate is not null) QueryParams["endDate"] = builder.EndDate;
            if (builder.StartDate is not null) QueryParams["startDate"] = builder.StartDate;
            if (deviceType is not null) QueryParams["deviceType"] = deviceType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGenerateReportV4(
            string namespace_,
            string? endDate,
            string? startDate,
            string deviceType
        )
        {
            PathParams["namespace"] = namespace_;

            if (endDate is not null) QueryParams["endDate"] = endDate;
            if (startDate is not null) QueryParams["startDate"] = startDate;
            if (deviceType is not null) QueryParams["deviceType"] = deviceType;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/report";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}