// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Sessionbrowser.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Sessionbrowser.Operation
{
    /// <summary>
    /// AddPlayerToSession
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// Add player to game session
    /// </summary>
    public class AddPlayerToSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AddPlayerToSessionBuilder Builder = new AddPlayerToSessionBuilder();

        public class AddPlayerToSessionBuilder
        {
            
            
            
            internal AddPlayerToSessionBuilder() { }





            public AddPlayerToSession Build(
                ModelsAddPlayerRequest body,
                string namespace_,
                string sessionID
            )
            {
                return new AddPlayerToSession(this,
                    body,                    
                    namespace_,                    
                    sessionID                    
                );
            }
        }

        private AddPlayerToSession(AddPlayerToSessionBuilder builder,
            ModelsAddPlayerRequest body,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public AddPlayerToSession(
            string namespace_,            
            string sessionID,            
            Model.ModelsAddPlayerRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsAddPlayerResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsAddPlayerResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsAddPlayerResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}