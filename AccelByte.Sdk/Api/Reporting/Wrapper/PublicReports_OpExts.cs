// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Api.Reporting.Operation;
using AccelByte.Sdk.Api.Reporting.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class ReportingPublicReports_OpExts
    {
        public static Reporting.Model.RestapiSubmitReportResponse? Execute(
            this SubmitReport.SubmitReportBuilder builder,
            RestapiSubmitReportRequest body,
            string namespace_
        )
        {
            SubmitReport op = builder.Build(
                body,
                namespace_
            );

            return ((Reporting.Wrapper.PublicReports)builder.WrapperObject!).SubmitReport(op);
        }
    }
}