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
    /// renameBatch
    ///
    /// Change campaign batch name.
    /// Other detail info:
    /// </summary>
    public class RenameBatch : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RenameBatchBuilder Builder { get => new RenameBatchBuilder(); }

        public class RenameBatchBuilder
            : OperationBuilder<RenameBatchBuilder>
        {





            internal RenameBatchBuilder() { }






            public RenameBatch Build(
                CampaignBatchNameChange body,
                string campaignId,
                string namespace_
            )
            {
                RenameBatch op = new RenameBatch(this,
                    body,
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

        private RenameBatch(RenameBatchBuilder builder,
            CampaignBatchNameChange body,
            string campaignId,
            string namespace_
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RenameBatch(
            string campaignId,
            string namespace_,
            Model.CampaignBatchNameChange body
        )
        {
            PathParams["campaignId"] = campaignId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/campaigns/{campaignId}/batchName";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}