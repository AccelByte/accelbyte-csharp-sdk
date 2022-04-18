// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Matchmaking.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Matchmaking.Operation
{
    /// <summary>
    /// DeleteSessionInChannel
    ///
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:MATCHMAKING:CHANNEL [Delete]
    /// 
    /// Required Scope: social
    /// 
    /// Delete a session in a channel.
    /// </summary>
    public class DeleteSessionInChannel : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteSessionInChannelBuilder Builder = new DeleteSessionInChannelBuilder();

        public class DeleteSessionInChannelBuilder
            : OperationBuilder<DeleteSessionInChannelBuilder>
        {
            
            
            
            internal DeleteSessionInChannelBuilder() { }





            public DeleteSessionInChannel Build(
                string channelName,
                string matchID,
                string namespace_
            )
            {
                DeleteSessionInChannel op = new DeleteSessionInChannel(this,
                    channelName,                    
                    matchID,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteSessionInChannel(DeleteSessionInChannelBuilder builder,
            string channelName,
            string matchID,
            string namespace_
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteSessionInChannel(
            string channelName,            
            string matchID,            
            string namespace_            
        )
        {
            PathParams["channelName"] = channelName;
            PathParams["matchID"] = matchID;
            PathParams["namespace"] = namespace_;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/matchmaking/v1/admin/namespaces/{namespace}/channels/{channelName}/sessions/{matchID}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
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