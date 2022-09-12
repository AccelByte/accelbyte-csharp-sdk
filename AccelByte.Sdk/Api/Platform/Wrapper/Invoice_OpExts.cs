// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Api.Platform.Wrapper;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api
{
    public static class PlatformInvoice_OpExts
    {
        public static void Execute(
            this DownloadInvoiceDetails.DownloadInvoiceDetailsBuilder builder,
            string namespace_,
            string endTime,
            string startTime
        )
        {
            DownloadInvoiceDetails op = builder.Build(
                namespace_,
                endTime,
                startTime
            );

            ((Platform.Wrapper.Invoice)builder.WrapperObject!).DownloadInvoiceDetails(op);
        }

        public static Platform.Model.InvoiceSummary? Execute(
            this GenerateInvoiceSummary.GenerateInvoiceSummaryBuilder builder,
            string namespace_,
            string endTime,
            string startTime
        )
        {
            GenerateInvoiceSummary op = builder.Build(
                namespace_,
                endTime,
                startTime
            );

            return ((Platform.Wrapper.Invoice)builder.WrapperObject!).GenerateInvoiceSummary(op);
        }

    }
}