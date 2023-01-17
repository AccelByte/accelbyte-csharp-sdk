// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminGetContentBulk
    ///
    /// Required permission ADMIN:NAMESPACE:{namespace}:USER:*:CONTENT [READ].
    /// Maximum contentId per request 100
    /// </summary>
    public class AdminGetContentBulk : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetContentBulkBuilder Builder = new AdminGetContentBulkBuilder();

        public class AdminGetContentBulkBuilder
            : OperationBuilder<AdminGetContentBulkBuilder>
        {





            internal AdminGetContentBulkBuilder() { }






            public AdminGetContentBulk Build(
                ModelsAdminGetContentBulkRequest body,
                string namespace_
            )
            {
                AdminGetContentBulk op = new AdminGetContentBulk(this,
                    body,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetContentBulk(AdminGetContentBulkBuilder builder,
            ModelsAdminGetContentBulkRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetContentBulk(
            string namespace_,            
            Model.ModelsAdminGetContentBulkRequest body            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v1/admin/namespaces/{namespace}/contents/bulk";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public List<Model.ModelsContentDownloadResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelsContentDownloadResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}