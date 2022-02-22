// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// createNamespace
    ///
    /// Create a namespace.
    /// By default the namespace is enabled.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "ADMIN:NAMESPACE" , action=1 (CREATE)
    ///   *  Action code : 11301
    ///   *  Returns : created namespace
    /// </summary>
    public class CreateNamespace : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateNamespaceBuilder Builder = new CreateNamespaceBuilder();

        public class CreateNamespaceBuilder
        {
            public Model.NamespaceCreate? Body { get; set; }
            
            internal CreateNamespaceBuilder() { }



            public CreateNamespaceBuilder SetBody(Model.NamespaceCreate _body)
            {
                Body = _body;
                return this;
            }



            public CreateNamespace Build(
            )
            {
                return new CreateNamespace(this
                );
            }
        }

        private CreateNamespace(CreateNamespaceBuilder builder
        )
        {
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public CreateNamespace(
            Model.NamespaceCreate body            
        )
        {
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/admin/namespaces";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.NamespaceInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.NamespaceInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.NamespaceInfo>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}