// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// RejectBackfill
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:BACKFILL [UPDATE]
    /// 
    /// Required Scope: social
    /// 
    /// Reject backfill proposal
    /// </summary>
    public class RejectBackfill : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RejectBackfillBuilder Builder { get => new RejectBackfillBuilder(); }

        public class RejectBackfillBuilder
            : OperationBuilder<RejectBackfillBuilder>
        {





            internal RejectBackfillBuilder() { }






            public RejectBackfill Build(
                ApiBackFillRejectRequest body,
                string backfillID,
                string namespace_
            )
            {
                RejectBackfill op = new RejectBackfill(this,
                    body,
                    backfillID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private RejectBackfill(RejectBackfillBuilder builder,
            ApiBackFillRejectRequest body,
            string backfillID,
            string namespace_
        )
        {
            PathParams["backfillID"] = backfillID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RejectBackfill(
            string backfillID,
            string namespace_,
            Model.ApiBackFillRejectRequest body
        )
        {
            PathParams["backfillID"] = backfillID;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/backfill/{backfillID}/proposal/reject";

        public override HttpMethod Method => HttpMethod.Put;

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