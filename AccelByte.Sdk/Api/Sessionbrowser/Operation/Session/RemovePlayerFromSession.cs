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
    /// RemovePlayerFromSession
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// Remove player from game session
    /// </summary>
    public class RemovePlayerFromSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RemovePlayerFromSessionBuilder Builder = new RemovePlayerFromSessionBuilder();

        public class RemovePlayerFromSessionBuilder
            : OperationBuilder<RemovePlayerFromSessionBuilder>
        {
            
            
            
            internal RemovePlayerFromSessionBuilder() { }





            public RemovePlayerFromSession Build(
                string namespace_,
                string sessionID,
                string userID
            )
            {
                RemovePlayerFromSession op = new RemovePlayerFromSession(this,
                    namespace_,                    
                    sessionID,                    
                    userID                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RemovePlayerFromSession(RemovePlayerFromSessionBuilder builder,
            string namespace_,
            string sessionID,
            string userID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            PathParams["userID"] = userID;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RemovePlayerFromSession(
            string namespace_,            
            string sessionID,            
            string userID            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            PathParams["userID"] = userID;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}/player/{userID}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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