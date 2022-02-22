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
    /// publishTemplateLocalizationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [CREATE]` with scope `social`
    /// 
    /// Publish notification template draft. Empty draft can not be published.
    /// 
    /// Action Code: 50210
    /// </summary>
    public class PublishTemplateLocalizationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublishTemplateLocalizationV1AdminBuilder Builder = new PublishTemplateLocalizationV1AdminBuilder();

        public class PublishTemplateLocalizationV1AdminBuilder
        {
            
            
            
            internal PublishTemplateLocalizationV1AdminBuilder() { }





            public PublishTemplateLocalizationV1Admin Build(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                return new PublishTemplateLocalizationV1Admin(this,
                    namespace_,                    
                    templateLanguage,                    
                    templateSlug                    
                );
            }
        }

        private PublishTemplateLocalizationV1Admin(PublishTemplateLocalizationV1AdminBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            
        }
        #endregion

        public PublishTemplateLocalizationV1Admin(
            string namespace_,            
            string templateLanguage,            
            string templateSlug            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}/publish";

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