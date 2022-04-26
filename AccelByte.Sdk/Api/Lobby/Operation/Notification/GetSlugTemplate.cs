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
    /// getSlugTemplate
    ///
    /// Required permission : `NAMESPACE:{namespace}:TEMPLATE [READ]` with scope `social`
    /// 
    /// Get all templates in a namespace
    /// </summary>
    public class GetSlugTemplate : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetSlugTemplateBuilder Builder = new GetSlugTemplateBuilder();

        public class GetSlugTemplateBuilder
            : OperationBuilder<GetSlugTemplateBuilder>
        {
            
            
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public long? Limit { get; set; }
            
            internal GetSlugTemplateBuilder() { }


            public GetSlugTemplateBuilder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public GetSlugTemplateBuilder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public GetSlugTemplateBuilder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }





            public GetSlugTemplate Build(
                string namespace_,
                string templateSlug
            )
            {
                GetSlugTemplate op = new GetSlugTemplate(this,
                    namespace_,                    
                    templateSlug                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetSlugTemplate(GetSlugTemplateBuilder builder,
            string namespace_,
            string templateSlug
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["templateSlug"] = templateSlug;
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetSlugTemplate(
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
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/notification/namespaces/{namespace}/templates/{templateSlug}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelTemplateLocalizationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelTemplateLocalizationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelTemplateLocalizationResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}