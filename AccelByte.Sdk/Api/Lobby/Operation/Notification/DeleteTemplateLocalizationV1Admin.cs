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
    /// deleteTemplateLocalizationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [DELETE]` with scope `social`
    /// 
    /// delete template localization
    /// 
    /// Action Code: 50209
    /// </summary>
    public class DeleteTemplateLocalizationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTemplateLocalizationV1AdminBuilder Builder = new DeleteTemplateLocalizationV1AdminBuilder();

        public class DeleteTemplateLocalizationV1AdminBuilder
            : OperationBuilder<DeleteTemplateLocalizationV1AdminBuilder>
        {
            
            
            
            internal DeleteTemplateLocalizationV1AdminBuilder() { }





            public DeleteTemplateLocalizationV1Admin Build(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                DeleteTemplateLocalizationV1Admin op = new DeleteTemplateLocalizationV1Admin(this,
                    namespace_,                    
                    templateLanguage,                    
                    templateSlug                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteTemplateLocalizationV1Admin(DeleteTemplateLocalizationV1AdminBuilder builder,
            string namespace_,
            string templateLanguage,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteTemplateLocalizationV1Admin(
            string namespace_,            
            string templateLanguage,            
            string templateSlug            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateLanguage"] = templateLanguage;
            PathParams["templateSlug"] = templateSlug;
            
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
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