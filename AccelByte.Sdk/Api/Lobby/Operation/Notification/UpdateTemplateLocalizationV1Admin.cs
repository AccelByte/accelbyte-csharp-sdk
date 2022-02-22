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
    /// updateTemplateLocalizationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [UPDATE]` with scope `social`
    /// 
    /// update template localization
    /// 
    /// Action Code: 50208
    /// </summary>
    public class UpdateTemplateLocalizationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateTemplateLocalizationV1AdminBuilder Builder = new UpdateTemplateLocalizationV1AdminBuilder();

        public class UpdateTemplateLocalizationV1AdminBuilder
        {
            
            
            
            
            internal UpdateTemplateLocalizationV1AdminBuilder() { }





            public UpdateTemplateLocalizationV1Admin Build(
                ModelUpdateTemplateRequest body,
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                return new UpdateTemplateLocalizationV1Admin(this,
                    body,                    
                    namespace_,                    
                    templateLanguage,                    
                    templateSlug                    
                );
            }
        }

        private UpdateTemplateLocalizationV1Admin(UpdateTemplateLocalizationV1AdminBuilder builder,
            ModelUpdateTemplateRequest body,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            BodyParams = body;
            
        }
        #endregion

        public UpdateTemplateLocalizationV1Admin(
            string namespace_,            
            string templateLanguage,            
            string templateSlug,            
            Model.ModelUpdateTemplateRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}";

        public override HttpMethod Method => HttpMethod.Put;

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