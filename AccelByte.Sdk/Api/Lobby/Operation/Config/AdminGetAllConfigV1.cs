// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminGetAllConfigV1
    ///
    /// Get lobby config of all namespaces.
    /// default MaxDSWaitTime is 120 (second)
    /// </summary>
    public class AdminGetAllConfigV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetAllConfigV1Builder Builder { get => new AdminGetAllConfigV1Builder(); }

        public class AdminGetAllConfigV1Builder
            : OperationBuilder<AdminGetAllConfigV1Builder>
        {





            internal AdminGetAllConfigV1Builder() { }






            public AdminGetAllConfigV1 Build(
            )
            {
                AdminGetAllConfigV1 op = new AdminGetAllConfigV1(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetAllConfigV1(AdminGetAllConfigV1Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetAllConfigV1(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/config";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsConfigList? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsConfigList>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsConfigList>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsConfigList>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}