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
    /// publicCreateParty
    ///
    /// A join code will be autogenerated if the party is joinable.
    /// 
    /// A user can be in 1 party at a time, therefore the requester will be removed from their previous party (if any) and automatically added/joined into this newly created party as a leader.
    /// 
    /// Session configuration name is optional.
    /// Default configuration name if empty:
    /// {
    /// "name": "default",
    /// "type": "NONE",
    /// "joinability": "OPEN",
    /// "minPlayers": 1,
    /// "maxPlayers": 8,
    /// "inviteTimeout": 60,
    /// "inactiveTimeout": 60,
    /// "textChat": false
    /// }
    /// When session configuration "name" is provided, we will refer to the template if these fields are empty:
    /// - textChat
    /// - minPlayers
    /// - maxPlayers
    /// - inviteTimeout
    /// - inactiveTimeout
    /// - type
    /// - joinability
    /// - configurationName
    /// - attributes
    /// 
    /// Supported platforms:
    /// 1. STEAM
    /// 2. PSN
    /// 3. XBOX
    /// 
    /// Reserved attributes key:
    /// 1. preference: used to store preference of the leader and it is non-replaceable to keep the initial behavior of
    /// the session regardless the leader changes.
    /// 2. NATIVESESSIONTITLE: used for session sync, to define name of session displayed on PlayStation system UI.
    /// 
    /// Session has 2 fields for user status: "status" and "statusV2". The "status" is there for backward-compatibility, therefore we encourage to just rely on "statusV2" for the more updated statuses.
    /// 
    /// User statuses:
    /// 1. INVITED: by default, to join a session (except session with OPEN joinability or if session configuration has "autoJoin" sets to True) a user will receive an invite. The invitee will have the chance to respond within "inviteTimeout" which you can configure through session configuration.
    /// 2. TIMEOUT: when a user is invited to a session, they will receive an invite. Unless "disableResendInvite" sets to True in the session configuration, the user will also receive invite reminder every 30s until they respond to the invite.
    /// 3. REJECTED: when a user rejects an invite. To rejoin an INVITE_ONLY session, they will need to be re-invited and accept the invite.
    /// 4. JOINED: there are few ways of a user to join a session, by invite, direct join (depends on session joinability) or join by code. upon invite, once a user accepts an invite, their status will be changed to JOINED.
    /// 5. LEFT: user can leave a session. in case of party, a user can only be in 1 party at a time. therefore when they decide to create or join another party, they will be automatically removed from their initial party and their status will be changed to LEFT.
    /// 6. KICKED: only party leader can kick a member.
    /// 7. DISCONNECTED: if user still have reserved seat in the session and they disconnect lobby websocket, their status in the session will be changed to DISCONNECTED and field "members.previousStatus" of that user will contains the initial status before they disconnect lobby websocket. the user will be given chance to reconnect within "inactiveTimeout" which you can configure through session configuration.
    /// 8. CONNECTED: when a user reconnect their lobby websocket, their status will change from DISCONNECTED to CONNECTED, only if they previously JOINED session. if they were on INVITED state before the disconnect happened, the user's status will return back to INVITED after they reconnect.
    /// 9. DROPPED: when "inactiveTimeout" is due and user never re-establish their websocket connection, we will drop them from the session.
    /// 10. TERMINATED: only applies to game session. If a game session (match) is ended, DS will end/delete the session and we will mark all remaining users' status to be TERMINATED.
    /// 11. CANCELLED: when a session joinability changes to CLOSED, any remaining invites will be canceled.
    /// 
    /// User is considered as active if they're present in the session, which their status either CONNECTED or JOINED.
    /// User has a reserved seat in the session if their status either INVITED, JOINED, CONNECTED, DISCONNECTED. When user's' status change to other than these mentioned statuses, we will release the seat for other players to occupy.
    /// 
    /// Managing the relation between session and lobby websocket connection:
    /// - Session relies on lobby to consider player's connection health to our backend. therefore a disruption to lobby websocket will be reflected in the user's status in all of their session(s).
    /// - If user still have a reserved seat in the session and they disconnect lobby websocket, their status in session(s) will be changed to DISCONNECTED and field "members.previousStatus" of that user will contains the initial status before they disconnect lobby websocket. This "members.previousStatus" used to track user's previous status before they disconnect websocket, since we still reserve a seat for them, therefore this field will be empty again after they websocket.
    /// - If the disconnected user is the leader of the session they're disconnected from, we will wait until "leaderElectionGracePeriod" is due, to promote the next oldest member as the new leader of the session. You can configure "leaderElectionGracePeriod" through session configuration.
    /// - The user will be given chance to reconnect within "inactiveTimeout" which you can configure through session configuration. If until "inactiveTimeout" is due and the user doesn't reconnect their websocket, they will be removed from session and their status will change to DROPPED. If the dropped user was the leader of the session, we will promote the next oldest member as leader.
    /// - By default, we will update user's status to what it was before disconnect, when the user reconnects lobby websocket, unless "manualRejoin" sets to True in the session configuration. When "manualRejoin" is enabled, after lobby websocket reconnect, the game client will need to manually invoke join session again to rejoin the session.
    /// - If the user was on INVITED state before the disconnect happened, the user's status will return back to INVITED after they reconnect.
    /// </summary>
    public class PublicCreateParty : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreatePartyBuilder Builder { get => new PublicCreatePartyBuilder(); }

        public class PublicCreatePartyBuilder
            : OperationBuilder<PublicCreatePartyBuilder>
        {





            internal PublicCreatePartyBuilder() { }






            public PublicCreateParty Build(
                ApimodelsCreatePartyRequest body,
                string namespace_
            )
            {
                PublicCreateParty op = new PublicCreateParty(this,
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

        private PublicCreateParty(PublicCreatePartyBuilder builder,
            ApimodelsCreatePartyRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateParty(
            string namespace_,
            Model.ApimodelsCreatePartyRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/party";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsPartySessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsPartySessionResponse<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPartySessionResponse<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}