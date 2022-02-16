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
    /// GetActiveCustomGameSessions
    ///
    /// Required permission: ADMIN:NAMESPACE:{namespace}:SESSIONBROWSER:SESSION [READ]
    /// 
    /// Required scope: social
    /// </summary>
    public class GetActiveCustomGameSessions : AccelByte.Sdk.Core.Operation
    {
        public GetActiveCustomGameSessions(
            string namespace_,            
            string? serverRegion,            
            string? sessionId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (serverRegion != null) QueryParams["server_region"] = serverRegion;
            if (sessionId != null) QueryParams["session_id"] = sessionId;
            
            
            
            
        }

        public override string Path => "/sessionbrowser/admin/namespaces/{namespace}/gamesession/active/custom-game";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsActiveCustomGameResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsActiveCustomGameResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsActiveCustomGameResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}