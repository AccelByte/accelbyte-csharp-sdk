// Copyright (c) 2022-2024 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Api.Platform.Operation;
using AccelByte.Sdk.Core;

namespace AccelByte.Sdk.Api.Platform.Wrapper
{
    public class Invoice
    {
        private readonly AccelByteSDK _sdk;

        public Invoice(AccelByteSDK sdk)
        {
            _sdk = sdk;
        }

        #region Operation Builders
        public DownloadInvoiceDetails.DownloadInvoiceDetailsBuilder DownloadInvoiceDetailsOp
        {
            get { return Operation.DownloadInvoiceDetails.Builder.SetWrapperObject(this); }
        }
        public GenerateInvoiceSummary.GenerateInvoiceSummaryBuilder GenerateInvoiceSummaryOp
        {
            get { return Operation.GenerateInvoiceSummary.Builder.SetWrapperObject(this); }
        }
        #endregion

        public Stream? DownloadInvoiceDetails(DownloadInvoiceDetails input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Stream?> DownloadInvoiceDetailsAsync(DownloadInvoiceDetails input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public Model.InvoiceSummary? GenerateInvoiceSummary(GenerateInvoiceSummary input)
        {
            var response = _sdk.RunRequest(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
        public async Task<Model.InvoiceSummary?> GenerateInvoiceSummaryAsync(GenerateInvoiceSummary input)
        {
            var response = await _sdk.RunRequestAsync(input);
            return input.ParseResponse(
                    response.Code,
                    response.ContentType,
                    response.Payload);
        }
    }
}