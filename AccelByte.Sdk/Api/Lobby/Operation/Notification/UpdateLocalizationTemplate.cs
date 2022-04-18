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
    /// updateLocalizationTemplate
    ///
    /// Required permission : `NAMESPACE:{namespace}:TEMPLATE [UPDATE]` with scope `social`
    /// 
    /// Modify draft template
    /// </summary>
    public class UpdateLocalizationTemplate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateLocalizationTemplateBuilder Builder = new UpdateLocalizationTemplateBuilder();

        public class UpdateLocalizationTemplateBuilder
            : OperationBuilder<UpdateLocalizationTemplateBuilder>
        {
            
            
            
            
            internal UpdateLocalizationTemplateBuilder() { }





            public UpdateLocalizationTemplate Build(
                ModelUpdateTemplateRequest body,
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                UpdateLocalizationTemplate op = new UpdateLocalizationTemplate(this,
                    body,                    
                    namespace_,                    
                    templateLanguage,                    
                    templateSlug                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateLocalizationTemplate(UpdateLocalizationTemplateBuilder builder,
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
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateLocalizationTemplate(
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
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/templates/{templateSlug}/languages/{templateLanguage}";

        public override HttpMethod Method => HttpMethod.Put;

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