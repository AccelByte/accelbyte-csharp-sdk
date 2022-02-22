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
    /// UpdateSession
    ///
    /// Required permission: NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [UPDATE]
    /// 
    /// Required scope: social
    /// 
    /// Update game session, used to update the current player
    /// </summary>
    public class UpdateSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateSessionBuilder Builder = new UpdateSessionBuilder();

        public class UpdateSessionBuilder
        {
            
            
            
            internal UpdateSessionBuilder() { }





            public UpdateSession Build(
                ModelsUpdateSessionRequest body,
                string namespace_,
                string sessionID
            )
            {
                return new UpdateSession(this,
                    body,                    
                    namespace_,                    
                    sessionID                    
                );
            }
        }

        private UpdateSession(UpdateSessionBuilder builder,
            ModelsUpdateSessionRequest body,
            string namespace_,
            string sessionID
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdateSession(
            string namespace_,            
            string sessionID,            
            Model.ModelsUpdateSessionRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["sessionID"] = sessionID;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/sessionbrowser/namespaces/{namespace}/gamesession/{sessionID}";

        public override HttpMethod Method => HttpMethod.Put;

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