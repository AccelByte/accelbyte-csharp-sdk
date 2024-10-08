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
    /// bulkEnableCodes
    ///
    /// Bulk enable campaign codes.
    /// Other detail info:
    /// 
    ///   * Returns : the number of code actually enabled
    /// </summary>
    public class BulkEnableCodes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkEnableCodesBuilder Builder { get => new BulkEnableCodesBuilder(); }

        public class BulkEnableCodesBuilder
            : OperationBuilder<BulkEnableCodesBuilder>
        {

            public string? BatchName { get; set; }

            public List<int>? BatchNo { get; set; }





            internal BulkEnableCodesBuilder() { }


            public BulkEnableCodesBuilder SetBatchName(string _batchName)
            {
                BatchName = _batchName;
                return this;
            }

            public BulkEnableCodesBuilder SetBatchNo(List<int> _batchNo)
            {
                BatchNo = _batchNo;
                return this;
            }





            public BulkEnableCodes Build(
                string campaignId,
                string namespace_
            )
            {
                BulkEnableCodes op = new BulkEnableCodes(this,
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

        private BulkEnableCodes(BulkEnableCodesBuilder builder,
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

        public BulkEnableCodes(
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

        public override string Path => "/platform/admin/namespaces/{namespace}/codes/campaigns/{campaignId}/enable/bulk";

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