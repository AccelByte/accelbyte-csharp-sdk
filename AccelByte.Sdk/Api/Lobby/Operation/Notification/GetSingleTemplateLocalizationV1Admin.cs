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
    /// getSingleTemplateLocalizationV1Admin
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:NOTIFICATION [READ]` with scope `social`
    /// 
    /// Get a template localization
    /// 
    /// Action Code: 50207
    /// </summary>
    public class GetSingleTemplateLocalizationV1Admin : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSingleTemplateLocalizationV1AdminBuilder Builder = new GetSingleTemplateLocalizationV1AdminBuilder();

        public class GetSingleTemplateLocalizationV1AdminBuilder
            : OperationBuilder<GetSingleTemplateLocalizationV1AdminBuilder>
        {
            
            
            
            internal GetSingleTemplateLocalizationV1AdminBuilder() { }






            public GetSingleTemplateLocalizationV1Admin Build(
                string namespace_,
                string templateLanguage,
                string templateSlug
            )
            {
                GetSingleTemplateLocalizationV1Admin op = new GetSingleTemplateLocalizationV1Admin(this,
                    namespace_,                    
                    templateLanguage,                    
                    templateSlug                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetSingleTemplateLocalizationV1Admin(GetSingleTemplateLocalizationV1AdminBuilder builder,
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

        public GetSingleTemplateLocalizationV1Admin(
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

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelLocalization? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLocalization>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLocalization>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}