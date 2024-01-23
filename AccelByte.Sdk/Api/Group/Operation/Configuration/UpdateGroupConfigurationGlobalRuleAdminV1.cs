// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Group.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Group.Operation
{
    /// <summary>
    /// updateGroupConfigurationGlobalRuleAdminV1
    ///
    /// 
    /// 
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to update existing global rule configuration based on the allowed action. It will replace the permission with the request
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73106
    /// </summary>
    public class UpdateGroupConfigurationGlobalRuleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateGroupConfigurationGlobalRuleAdminV1Builder Builder { get => new UpdateGroupConfigurationGlobalRuleAdminV1Builder(); }

        public class UpdateGroupConfigurationGlobalRuleAdminV1Builder
            : OperationBuilder<UpdateGroupConfigurationGlobalRuleAdminV1Builder>
        {





            internal UpdateGroupConfigurationGlobalRuleAdminV1Builder() { }






            public UpdateGroupConfigurationGlobalRuleAdminV1 Build(
                ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body,
                string allowedAction,
                string configurationCode,
                string namespace_
            )
            {
                UpdateGroupConfigurationGlobalRuleAdminV1 op = new UpdateGroupConfigurationGlobalRuleAdminV1(this,
                    body,
                    allowedAction,
                    configurationCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateGroupConfigurationGlobalRuleAdminV1(UpdateGroupConfigurationGlobalRuleAdminV1Builder builder,
            ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body,
            string allowedAction,
            string configurationCode,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateGroupConfigurationGlobalRuleAdminV1(
            string allowedAction,
            string configurationCode,
            string namespace_,
            Model.ModelsUpdateGroupConfigurationGlobalRulesRequestV1 body
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}/rules/{allowedAction}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsUpdateGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}