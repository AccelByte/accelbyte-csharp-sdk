// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Match2.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Match2.Operation
{
    /// <summary>
    /// DeleteRuleSet
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:RULES [DELETE]
    /// 
    /// Required Scope: social
    /// 
    /// Deletes an existing rule set.
    /// </summary>
    public class DeleteRuleSet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteRuleSetBuilder Builder = new DeleteRuleSetBuilder();

        public class DeleteRuleSetBuilder
            : OperationBuilder<DeleteRuleSetBuilder>
        {





            internal DeleteRuleSetBuilder() { }






            public DeleteRuleSet Build(
                string namespace_,
                string ruleset
            )
            {
                DeleteRuleSet op = new DeleteRuleSet(this,
                    namespace_,                    
                    ruleset                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteRuleSet(DeleteRuleSetBuilder builder,
            string namespace_,
            string ruleset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleset"] = ruleset;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteRuleSet(
            string namespace_,            
            string ruleset            
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleset"] = ruleset;
            
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/rulesets/{ruleset}";

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