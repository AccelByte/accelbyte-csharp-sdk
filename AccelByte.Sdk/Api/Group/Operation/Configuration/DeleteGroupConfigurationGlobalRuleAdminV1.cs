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
    /// deleteGroupConfigurationGlobalRuleAdminV1
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:GROUP:CONFIGURATION [UPDATE]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is used to delete existing global rule configuration based on the allowed action. It will not give any error if the allowed action is not existed in the global rule
    /// 
    /// 
    /// 
    /// 
    /// Action Code: 73105
    /// </summary>
    public class DeleteGroupConfigurationGlobalRuleAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteGroupConfigurationGlobalRuleAdminV1Builder Builder { get => new DeleteGroupConfigurationGlobalRuleAdminV1Builder(); }

        public class DeleteGroupConfigurationGlobalRuleAdminV1Builder
            : OperationBuilder<DeleteGroupConfigurationGlobalRuleAdminV1Builder>
        {





            internal DeleteGroupConfigurationGlobalRuleAdminV1Builder() { }






            public DeleteGroupConfigurationGlobalRuleAdminV1 Build(
                string allowedAction,
                string configurationCode,
                string namespace_
            )
            {
                DeleteGroupConfigurationGlobalRuleAdminV1 op = new DeleteGroupConfigurationGlobalRuleAdminV1(this,
                    allowedAction,
                    configurationCode,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private DeleteGroupConfigurationGlobalRuleAdminV1(DeleteGroupConfigurationGlobalRuleAdminV1Builder builder,
            string allowedAction,
            string configurationCode,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteGroupConfigurationGlobalRuleAdminV1(
            string allowedAction,
            string configurationCode,
            string namespace_
        )
        {
            PathParams["allowedAction"] = allowedAction;
            PathParams["configurationCode"] = configurationCode;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/group/v1/admin/namespaces/{namespace}/configuration/{configurationCode}/rules/{allowedAction}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsUpdateGroupConfigurationResponseV1? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsUpdateGroupConfigurationResponseV1>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}