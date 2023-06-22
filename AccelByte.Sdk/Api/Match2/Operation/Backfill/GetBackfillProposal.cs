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
    /// GetBackfillProposal
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:BACKFILL [GET]
    /// 
    /// Required Scope: social
    /// 
    /// Get backfill proposal
    /// </summary>
    public class GetBackfillProposal : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetBackfillProposalBuilder Builder { get => new GetBackfillProposalBuilder(); }

        public class GetBackfillProposalBuilder
            : OperationBuilder<GetBackfillProposalBuilder>
        {





            internal GetBackfillProposalBuilder() { }






            public GetBackfillProposal Build(
                string namespace_,
                string sessionID
            )
            {
                GetBackfillProposal op = new GetBackfillProposal(this,
                    namespace_,
                    sessionID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private GetBackfillProposal(GetBackfillProposalBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;

            if (sessionID is not null) QueryParams["sessionID"] = sessionID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetBackfillProposal(
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;

            if (sessionID is not null) QueryParams["sessionID"] = sessionID;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/backfill/proposal";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiBackfillProposalResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiBackfillProposalResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiBackfillProposalResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiBackfillProposalResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}