// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// createGameSession
    ///
    /// Create a game session.
    /// Session configuration name is mandatory, this API will refer following values from the session template if they're not provided in the request:
    /// - type
    /// - joinability
    /// - autoJoin. If enabled (set to true), players provided in the request will automatically joined the initial game session creation. Game session will not send any invite and players dont need to act upon it.
    /// - minPlayers
    /// - maxPlayers
    /// - inviteTimeout
    /// - inactiveTimeout
    /// - dsSource
    /// - tieTeamsSessionLifetime
    /// 
    /// When the tieTeamsSessionLifetime is true, the lifetime of any partyId inside teams attribute will be tied to the game session.
    /// Only applies when the teams partyId is a game session.
    /// 
    /// When the session type is a DS, a DS creation request will be sent if number of active players reaches session's minPlayers.
    /// 
    /// Active user is a user who present within the session, has status CONNECTED/JOINED.
    /// 
    /// Session service has several DSInformation status to track DS request to DSMC:
    /// - NEED_TO_REQUEST: number of active players hasn't reached session's minPlayers therefore DS has not yet requested.
    /// - REQUESTED: DS is being requested to DSMC.
    /// - AVAILABLE: DS is ready to use. The DSMC status for this DS is either READY/BUSY.
    /// - FAILED_TO_REQUEST: DSMC fails to create the DS.
    /// 
    /// By default, DS requests are sent to DSMC, but if dsSource is set to "AMS":
    /// - A DS will be requested from AMS instead of DSMC.
    /// - The server will be chosen based on a set of claim keys, in order of preference, to match with fleets.
    /// - The claim key list is built build from the preferredClaimKeys, fallbackClaimKeys, and clientVersion as follows:
    /// [preferredClaimKeys.., clientVersion, fallbackClaimKeys...]
    /// </summary>
    public class CreateGameSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateGameSessionBuilder Builder { get => new CreateGameSessionBuilder(); }

        public class CreateGameSessionBuilder
            : OperationBuilder<CreateGameSessionBuilder>
        {





            internal CreateGameSessionBuilder() { }






            public CreateGameSession Build(
                ApimodelsCreateGameSessionRequest body,
                string namespace_
            )
            {
                CreateGameSession op = new CreateGameSession(this,
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

        private CreateGameSession(CreateGameSessionBuilder builder,
            ApimodelsCreateGameSessionRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateGameSession(
            string namespace_,
            Model.ApimodelsCreateGameSessionRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesession";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsGameSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsGameSessionResponse<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsGameSessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}