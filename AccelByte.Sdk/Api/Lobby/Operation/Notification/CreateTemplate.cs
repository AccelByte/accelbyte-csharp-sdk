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
    /// createTemplate
    ///
    /// Required permission : `NAMESPACE:{namespace}:TEMPLATE [CREATE]` with scope `social`
    /// 
    /// Create new notification template. Include handlebars {{key}} for replaceable contexts. The the key inside
    /// handlebars will be the key to be replaced when sending notification. Already existing template with the same
    /// slug and language can not be created.
    /// 
    /// Check model description for detailed input restrictions.
    /// </summary>
    public class CreateTemplate : AccelByte.Sdk.Core.Operation
    {
        public CreateTemplate(
            string namespace_,            
            Model.ModelCreateTemplateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/notification/namespaces/{namespace}/templates";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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