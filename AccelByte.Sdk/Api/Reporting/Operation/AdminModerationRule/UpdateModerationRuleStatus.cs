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
    /// updateModerationRuleStatus
    ///
    /// 
    /// 
    /// This endpoint enable/disable moderation rule status.
    /// 
    /// 
    /// 
    /// 
    /// Required Permission: ADMIN:NAMESPACE:{namespace}:RULE [UPDATE]
    /// </summary>
    public class UpdateModerationRuleStatus : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateModerationRuleStatusBuilder Builder { get => new UpdateModerationRuleStatusBuilder(); }

        public class UpdateModerationRuleStatusBuilder
            : OperationBuilder<UpdateModerationRuleStatusBuilder>
        {





            internal UpdateModerationRuleStatusBuilder() { }






            public UpdateModerationRuleStatus Build(
                RestapiModerationRuleActiveRequest body,
                string namespace_,
                string ruleId
            )
            {
                UpdateModerationRuleStatus op = new UpdateModerationRuleStatus(this,
                    body,
                    namespace_,
                    ruleId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private UpdateModerationRuleStatus(UpdateModerationRuleStatusBuilder builder,
            RestapiModerationRuleActiveRequest body,
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

        public UpdateModerationRuleStatus(
            string namespace_,
            string ruleId,
            Model.RestapiModerationRuleActiveRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["ruleId"] = ruleId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/reporting/v1/admin/namespaces/{namespace}/rule/{ruleId}/status";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
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