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
    /// publicGameSessionInvite
    ///
    /// Invite a user to a game session.
    /// platformID represents the native platform of the invitee. API will return the corresponding native platform's userID.
    /// supported platforms:
    /// - STEAM
    /// - XBOX
    /// - PSN
    /// </summary>
    public class PublicGameSessionInvite : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGameSessionInviteBuilder Builder { get => new PublicGameSessionInviteBuilder(); }

        public class PublicGameSessionInviteBuilder
            : OperationBuilder<PublicGameSessionInviteBuilder>
        {





            internal PublicGameSessionInviteBuilder() { }






            public PublicGameSessionInvite Build(
                ApimodelsSessionInviteRequest body,
                string namespace_,
                string sessionId
            )
            {
                PublicGameSessionInvite op = new PublicGameSessionInvite(this,
                    body,
                    namespace_,
                    sessionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGameSessionInvite(PublicGameSessionInviteBuilder builder,
            ApimodelsSessionInviteRequest body,
            string namespace_,
            string sessionId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGameSessionInvite(
            string namespace_,
            string sessionId,
            Model.ApimodelsSessionInviteRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}/invite";

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