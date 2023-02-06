// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminUpdateConfigurationTemplateV1
    ///
    /// Update template configuration
    /// </summary>
    public class AdminUpdateConfigurationTemplateV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateConfigurationTemplateV1Builder Builder { get => new AdminUpdateConfigurationTemplateV1Builder(); }

        public class AdminUpdateConfigurationTemplateV1Builder
            : OperationBuilder<AdminUpdateConfigurationTemplateV1Builder>
        {





            internal AdminUpdateConfigurationTemplateV1Builder() { }






            public AdminUpdateConfigurationTemplateV1 Build(
                ApimodelsUpdateConfigurationTemplateRequest body,
                string name,
                string namespace_
            )
            {
                AdminUpdateConfigurationTemplateV1 op = new AdminUpdateConfigurationTemplateV1(this,
                    body,                    
                    name,                    
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminUpdateConfigurationTemplateV1(AdminUpdateConfigurationTemplateV1Builder builder,
            ApimodelsUpdateConfigurationTemplateRequest body,
            string name,
            string namespace_
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateConfigurationTemplateV1(
            string name,            
            string namespace_,            
            Model.ApimodelsUpdateConfigurationTemplateRequest body            
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            
            

            
            
            BodyParams = body;
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/configurations/{name}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ApimodelsConfigurationTemplateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }

}