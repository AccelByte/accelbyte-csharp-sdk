// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// GetSessionHistoryDetailed
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [Read]
    /// 
    /// Required Scope: social
    /// 
    /// Get session history detailed.
    /// 
    /// if party_id value empty/null, field will not show in response body.
    /// </summary>
    public class GetSessionHistoryDetailed : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSessionHistoryDetailedBuilder Builder = new GetSessionHistoryDetailedBuilder();

        public class GetSessionHistoryDetailedBuilder
            : OperationBuilder<GetSessionHistoryDetailedBuilder>
        {





            internal GetSessionHistoryDetailedBuilder() { }






            public GetSessionHistoryDetailed Build(
                string matchID,
                string namespace_
            )
            {
                GetSessionHistoryDetailed op = new GetSessionHistoryDetailed(this,
                    matchID,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetSessionHistoryDetailed(GetSessionHistoryDetailedBuilder builder,
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSessionHistoryDetailed(
            string matchID,
            string namespace_
        )
        {
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/sessions/{matchID}/history/detailed";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelsGetSessionHistoryDetailedResponseItem>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsGetSessionHistoryDetailedResponseItem>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsGetSessionHistoryDetailedResponseItem>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}