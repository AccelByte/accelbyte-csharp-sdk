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
    /// deleteTemplateLocalization
    ///
    /// Required permission : `NAMESPACE:{namespace}:TEMPLATE [DELETE]` with scope `social`
    /// 
    /// Delete all template in a slug
    /// </summary>
    public class DeleteTemplateLocalization : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTemplateLocalizationBuilder Builder = new DeleteTemplateLocalizationBuilder();

        public class DeleteTemplateLocalizationBuilder
        {
            
            
            
            internal DeleteTemplateLocalizationBuilder() { }





            public DeleteTemplateLocalization Build(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                return new DeleteTemplateLocalization(this,
                    namespace_,                    
                    templateLanguage,                    
                    templateSlug                    
                );
            }
        }

        private DeleteTemplateLocalization(DeleteTemplateLocalizationBuilder builder,
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

        public DeleteTemplateLocalization(
            string namespace_,            
            string templateLanguage,            
            string templateSlug            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            
        }

        public override string Path => "/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}";

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