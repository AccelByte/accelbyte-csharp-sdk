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
    /// CreateMatchTicket
    ///
    /// Creates a new request for matchmaking.
    /// 
    /// Cross Platform: Allow player to play game with "any" registered platforms.
    /// 1. Cross Platform can be enabled through session service or create match ticket.
    /// a. via ticket: specify several cross_platform on create match ticket attributes.
    /// This value will override player attributes in session service. e.g. cross_platform:[xbox,psn,steam]
    /// b. via session service: set player/party cross_platform attributes.
    /// c. Enable match options ruleset with name cross_platform and type "any".
    /// {
    /// "name": "co-op",
    /// "data": {
    /// "alliance": {
    /// "min_number": 1,
    /// "max_number": 1,
    /// "player_min_number": 1,
    /// "player_max_number": 4
    /// },
    /// "match_options": {
    /// "options": [
    /// {ânameâ: âcross_platformâ, âtypeâ: âanyâ}
    /// ]
    /// }
    /// }
    /// }
    /// 2. Cross Platform can be disabled with specify only ONE cross_platform. Current matchmaking use this behavior. e.g. cross_platform:[xbox]
    /// 3. Matchmaking will consider Party leader cross_platform preference or Session attribute cross_platform preference.
    /// 4. This behavior only works for Default Matchmaker. Custom matchmaker (custom gRPC matchmaker) need to consider this on its own implementation.
    /// </summary>
    public class CreateMatchTicket : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateMatchTicketBuilder Builder { get => new CreateMatchTicketBuilder(); }

        public class CreateMatchTicketBuilder
            : OperationBuilder<CreateMatchTicketBuilder>
        {





            internal CreateMatchTicketBuilder() { }






            public CreateMatchTicket Build(
                ApiMatchTicketRequest body,
                string namespace_
            )
            {
                CreateMatchTicket op = new CreateMatchTicket(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateMatchTicket(CreateMatchTicketBuilder builder,
            ApiMatchTicketRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateMatchTicket(
            string namespace_,
            Model.ApiMatchTicketRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/match-tickets";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiMatchTicketResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiMatchTicketResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiMatchTicketResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiMatchTicketResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}