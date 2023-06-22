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
    /// DeleteUserFromSessionInChannel
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Delete]
    /// 
    /// Required Scope: social
    /// 
    /// Delete a user from a session in the channel.
    /// </summary>
    public class DeleteUserFromSessionInChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteUserFromSessionInChannelBuilder Builder { get => new DeleteUserFromSessionInChannelBuilder(); }

        public class DeleteUserFromSessionInChannelBuilder
            : OperationBuilder<DeleteUserFromSessionInChannelBuilder>
        {





            internal DeleteUserFromSessionInChannelBuilder() { }






            public DeleteUserFromSessionInChannel Build(
                string channelName,
                string matchID,
                string namespace_,
                string userID
            )
            {
                DeleteUserFromSessionInChannel op = new DeleteUserFromSessionInChannel(this,
                    channelName,
                    matchID,
                    namespace_,
                    userID
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private DeleteUserFromSessionInChannel(DeleteUserFromSessionInChannelBuilder builder,
            string channelName,
            string matchID,
            string namespace_,
            string userID
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            PathParams["userID"] = userID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteUserFromSessionInChannel(
            string channelName,
            string matchID,
            string namespace_,
            string userID
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            PathParams["userID"] = userID;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}/users/{userID}";

        public override HttpMethod Method => HttpMethod.Delete;

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