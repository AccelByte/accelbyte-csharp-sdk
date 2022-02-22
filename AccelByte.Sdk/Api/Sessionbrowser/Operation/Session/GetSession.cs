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
    /// GetSession
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [READ]
    /// 
    /// Required scope: social
    /// 
    /// Get the session by session ID
    /// </summary>
    public class GetSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSessionBuilder Builder = new GetSessionBuilder();

        public class GetSessionBuilder
        {
            
            
            internal GetSessionBuilder() { }





            public GetSession Build(
                string namespace_,
                string sessionID
            )
            {
                return new GetSession(this,
                    namespace_,                    
                    sessionID                    
                );
            }
        }

        private GetSession(GetSessionBuilder builder,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            
            
            
            
        }
        #endregion

        public GetSession(
            string namespace_,            
            string sessionID            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            
            
            
            
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsSessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}