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
    /// deleteTemplateSlug
    ///
    /// Required permission : `NAMESPACE:{namespace}:TEMPLATE [DELETE]` with scope `social`
    /// 
    /// Delete localization template
    /// </summary>
    public class DeleteTemplateSlug : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteTemplateSlugBuilder Builder = new DeleteTemplateSlugBuilder();

        public class DeleteTemplateSlugBuilder
            : OperationBuilder<DeleteTemplateSlugBuilder>
        {
            
            
            internal DeleteTemplateSlugBuilder() { }






            public DeleteTemplateSlug Build(
                string namespace_,
                string templateSlug
            )
            {
                DeleteTemplateSlug op = new DeleteTemplateSlug(this,
                    namespace_,                    
                    templateSlug                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteTemplateSlug(DeleteTemplateSlugBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteTemplateSlug(
            string namespace_,            
            string templateSlug            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/templates/{templateSlug}";

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