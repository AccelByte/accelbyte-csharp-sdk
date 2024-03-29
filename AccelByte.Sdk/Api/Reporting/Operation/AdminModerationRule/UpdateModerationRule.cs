// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Reporting.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Reporting.Operation
{
    /// <summary>
    /// updateModerationRule
    ///
    /// This endpoint update moderation rule.
    /// Supported Category:- UGC - USER - CHAT - EXTENSION
    /// Supported Action (GOING TO DEPRECATE, for replacement please use "actions"):
    /// * HideContent
    /// 
    /// Supported Actions:
    /// * **hideContent**: Hide the content
    /// * **banAccount**: Ban the user account
    /// * **deleteChat**: Delete chat
    /// </summary>
    public class UpdateModerationRule : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateModerationRuleBuilder Builder { get => new UpdateModerationRuleBuilder(); }

        public class UpdateModerationRuleBuilder
            : OperationBuilder<UpdateModerationRuleBuilder>
        {





            internal UpdateModerationRuleBuilder() { }






            public UpdateModerationRule Build(
                RestapiModerationRuleRequest body,
                string namespace_,
                string ruleId
            )
            {
                UpdateModerationRule op = new UpdateModerationRule(this,
                    body,
                    namespace_,
                    ruleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateModerationRule(UpdateModerationRuleBuilder builder,
            RestapiModerationRuleRequest body,
            string namespace_,
            string ruleId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleId"] = ruleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateModerationRule(
            string namespace_,
            string ruleId,
            Model.RestapiModerationRuleRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleId"] = ruleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/rule/{ruleId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RestapiModerationRuleResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RestapiModerationRuleResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RestapiModerationRuleResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RestapiModerationRuleResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}