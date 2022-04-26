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
    /// adminGetProfanityRule
    ///
    /// Required permission : `ADMIN:NAMESPACE:{namespace}:PROFANITY [READ]` with scope `social`
    /// 
    /// get current profanity rule
    /// </summary>
    public class AdminGetProfanityRule : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetProfanityRuleBuilder Builder = new AdminGetProfanityRuleBuilder();

        public class AdminGetProfanityRuleBuilder
            : OperationBuilder<AdminGetProfanityRuleBuilder>
        {
            
            internal AdminGetProfanityRuleBuilder() { }






            public AdminGetProfanityRule Build(
                string namespace_
            )
            {
                AdminGetProfanityRule op = new AdminGetProfanityRule(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetProfanityRule(AdminGetProfanityRuleBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetProfanityRule(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/profanity/namespaces/{namespace}/rule";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsProfanityRule? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsProfanityRule>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsProfanityRule>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}