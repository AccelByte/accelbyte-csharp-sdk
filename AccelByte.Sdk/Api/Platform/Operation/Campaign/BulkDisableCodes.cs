// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// bulkDisableCodes
    ///
    /// Bulk disable codes.
    /// 
    /// Bulk disable campaign codes, all matched codes will be disabled except those have already been redeemed.
    /// Other detail info:
    /// 
    ///   * Returns : the number of code actually disabled
    /// </summary>
    public class BulkDisableCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkDisableCodesBuilder Builder { get => new BulkDisableCodesBuilder(); }

        public class BulkDisableCodesBuilder
            : OperationBuilder<BulkDisableCodesBuilder>
        {

            public string? BatchName { get; set; }

            public List<int>? BatchNo { get; set; }





            internal BulkDisableCodesBuilder() { }


            public BulkDisableCodesBuilder SetBatchName(string _batchName)
            {
                BatchName = _batchName;
                return this;
            }

            public BulkDisableCodesBuilder SetBatchNo(List<int> _batchNo)
            {
                BatchNo = _batchNo;
                return this;
            }





            public BulkDisableCodes Build(
                string campaignId,
                string namespace_
            )
            {
                BulkDisableCodes op = new BulkDisableCodes(this,
                    campaignId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private BulkDisableCodes(BulkDisableCodesBuilder builder,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (builder.BatchName is not null) QueryParams["batchName"] = builder.BatchName;
            if (builder.BatchNo is not null) QueryParams["batchNo"] = builder.BatchNo;



            CollectionFormatMap["batchNo"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkDisableCodes(
            string campaignId,
            string namespace_,
            string? batchName,
            List<int>? batchNo
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;

            if (batchName is not null) QueryParams["batchName"] = batchName;
            if (batchNo is not null) QueryParams["batchNo"] = batchNo;



            CollectionFormatMap["batchNo"] = "multi";



            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/disable/bulk";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.BulkOperationResult? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.BulkOperationResult>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}