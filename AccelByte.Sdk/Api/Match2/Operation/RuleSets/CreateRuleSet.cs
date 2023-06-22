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
    /// CreateRuleSet
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:RULES [CREATE]
    /// 
    /// Required Scope: social
    /// 
    /// Creates a new rules set.
    /// 
    /// A rule set has a name and contains arbitrary data which is meaningful to some particular match function(s)
    /// The name is used for a match pool to select the ruleset data that should be sent to the match function when matchmaking in that pool.
    /// 
    /// To use custom rules set please set enable_custom_match_function=true. Default (false).
    /// </summary>
    public class CreateRuleSet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateRuleSetBuilder Builder { get => new CreateRuleSetBuilder(); }

        public class CreateRuleSetBuilder
            : OperationBuilder<CreateRuleSetBuilder>
        {





            internal CreateRuleSetBuilder() { }






            public CreateRuleSet Build(
                ApiRuleSetPayload body,
                string namespace_
            )
            {
                CreateRuleSet op = new CreateRuleSet(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private CreateRuleSet(CreateRuleSetBuilder builder,
            ApiRuleSetPayload body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateRuleSet(
            string namespace_,
            Model.ApiRuleSetPayload body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/rulesets";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}