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
    /// getTemplateSlugLocalizationsTemplateV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [READ]` with scope `social`
    /// 
    /// Get all templates in a namespace
    /// 
    /// Action Code: 50205
    /// </summary>
    public class GetTemplateSlugLocalizationsTemplateV1Admin : AccelByte.Sdk.Core.Operation
    {
        public GetTemplateSlugLocalizationsTemplateV1Admin(
            string namespace_,            
            string templateSlug,            
            string? after,            
            string? before,            
            long? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetAllNotificationTemplateSlugResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetAllNotificationTemplateSlugResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetAllNotificationTemplateSlugResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}