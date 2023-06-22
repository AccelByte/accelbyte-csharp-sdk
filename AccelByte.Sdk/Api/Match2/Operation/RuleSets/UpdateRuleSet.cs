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
    /// UpdateRuleSet
    ///
    /// Required Permission: NAMESPACE:{namespace}:MATCHMAKING:RULES [UPDATE]
    /// 
    /// Required Scope: social
    /// 
    /// Updates an existing matchmaking rule set.
    /// 
    /// To use custom rules set please set enable_custom_match_function=true. Default (false).
    /// </summary>
    public class UpdateRuleSet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRuleSetBuilder Builder { get => new UpdateRuleSetBuilder(); }

        public class UpdateRuleSetBuilder
            : OperationBuilder<UpdateRuleSetBuilder>
        {





            internal UpdateRuleSetBuilder() { }






            public UpdateRuleSet Build(
                ApiRuleSetPayload body,
                string namespace_,
                string ruleset
            )
            {
                UpdateRuleSet op = new UpdateRuleSet(this,
                    body,
                    namespace_,
                    ruleset
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private UpdateRuleSet(UpdateRuleSetBuilder builder,
            ApiRuleSetPayload body,
            string namespace_,
            string ruleset
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleset"] = ruleset;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateRuleSet(
            string namespace_,
            string ruleset,
            Model.ApiRuleSetPayload body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleset"] = ruleset;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/match2/v1/namespaces/{namespace}/rulesets/{ruleset}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApiRuleSetPayload? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApiRuleSetPayload>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApiRuleSetPayload>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiRuleSetPayload>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApiRuleSetPayload<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApiRuleSetPayload<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApiRuleSetPayload<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}