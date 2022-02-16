// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Dsmc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Dsmc.Operation
{
    /// <summary>
    /// GetServerSession
    ///
    /// ```
    /// Required permission: NAMESPACE:{namespace}:DSM:SERVER [UPDATE]
    /// Required scope: social
    /// 
    /// This endpoint is intended to be called by dedicated server
    /// to query its session ID.
    /// DS should call this when it first receive player connection,
    /// to see if it is actually claimed```
    /// </summary>
    public class GetServerSession : AccelByte.Sdk.Core.Operation
    {
        public GetServerSession(
            string namespace_,            
            string podName            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["podName"] = podName;
            
            
            
            
            
        }

        public override string Path => "/dsmcontroller/namespaces/{namespace}/servers/{podName}/session";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelsServerSessionResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsServerSessionResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsServerSessionResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}