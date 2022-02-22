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
    /// deleteNotificationTemplateSlugV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [DELETE]` with scope `social`
    /// 
    /// Delete template slug in notification template
    /// 
    /// Action Code: 50206
    /// </summary>
    public class DeleteNotificationTemplateSlugV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteNotificationTemplateSlugV1AdminBuilder Builder = new DeleteNotificationTemplateSlugV1AdminBuilder();

        public class DeleteNotificationTemplateSlugV1AdminBuilder
        {
            
            
            internal DeleteNotificationTemplateSlugV1AdminBuilder() { }





            public DeleteNotificationTemplateSlugV1Admin Build(
                string namespace_,
                string templateSlug
            )
            {
                return new DeleteNotificationTemplateSlugV1Admin(this,
                    namespace_,                    
                    templateSlug                    
                );
            }
        }

        private DeleteNotificationTemplateSlugV1Admin(DeleteNotificationTemplateSlugV1AdminBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            
        }
        #endregion

        public DeleteNotificationTemplateSlugV1Admin(
            string namespace_,            
            string templateSlug            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}";

        public override HttpMethod Method => HttpMethod.Delete;

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