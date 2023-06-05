// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// BulkCreateMockTickets
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Create]
    /// 
    /// Required Scope: social
    /// 
    /// Create and queue mock tickets into specified game mode's pool.
    /// The tickets input will be used as is.
    /// '
    /// </summary>
    public class BulkCreateMockTickets : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static BulkCreateMockTicketsBuilder Builder { get => new BulkCreateMockTicketsBuilder(); }

        public class BulkCreateMockTicketsBuilder
            : OperationBuilder<BulkCreateMockTicketsBuilder>
        {





            internal BulkCreateMockTicketsBuilder() { }






            public BulkCreateMockTickets Build(
                List<ModelsMatchingParty> body,
                string channelName,
                string namespace_
            )
            {
                BulkCreateMockTickets op = new BulkCreateMockTickets(this,
                    body,
                    channelName,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private BulkCreateMockTickets(BulkCreateMockTicketsBuilder builder,
            List<ModelsMatchingParty> body,
            string channelName,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public BulkCreateMockTickets(
            string channelName,
            string namespace_,
            List<Model.ModelsMatchingParty> body
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/mocks/tickets/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}