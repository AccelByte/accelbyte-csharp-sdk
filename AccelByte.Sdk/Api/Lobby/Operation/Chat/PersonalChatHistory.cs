// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// personalChatHistory
    ///
    /// Required permission : `NAMESPACE:{namespace}:USER:{userId}:CHAT [READ]` with scope `social`
    /// 
    /// load personal chat history in a namespace.
    /// </summary>
    public class PersonalChatHistory : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PersonalChatHistoryBuilder Builder = new PersonalChatHistoryBuilder();

        public class PersonalChatHistoryBuilder
            : OperationBuilder<PersonalChatHistoryBuilder>
        {
            
            
            
            internal PersonalChatHistoryBuilder() { }





            public PersonalChatHistory Build(
                string friendId,
                string namespace_,
                string userId
            )
            {
                PersonalChatHistory op = new PersonalChatHistory(this,
                    friendId,                    
                    namespace_,                    
                    userId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PersonalChatHistory(PersonalChatHistoryBuilder builder,
            string friendId,
            string namespace_,
            string userId
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PersonalChatHistory(
            string friendId,            
            string namespace_,            
            string userId            
        )
        {
            PathParams["friendId"] = friendId;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/chat/namespaces/{namespace}/users/{userId}/friend/{friendId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ModelChatMessageResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelChatMessageResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelChatMessageResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}