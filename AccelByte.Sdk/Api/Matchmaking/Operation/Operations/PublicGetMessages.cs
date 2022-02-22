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
    /// publicGetMessages
    ///
    /// get the list of messages.
    /// </summary>
    public class PublicGetMessages : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMessagesBuilder Builder = new PublicGetMessagesBuilder();

        public class PublicGetMessagesBuilder
        {
            internal PublicGetMessagesBuilder() { }





            public PublicGetMessages Build(
            )
            {
                return new PublicGetMessages(this
                );
            }
        }

        private PublicGetMessages(PublicGetMessagesBuilder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public PublicGetMessages(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/matchmaking/v1/messages";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.LogAppMessageDeclaration>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.LogAppMessageDeclaration>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.LogAppMessageDeclaration>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}