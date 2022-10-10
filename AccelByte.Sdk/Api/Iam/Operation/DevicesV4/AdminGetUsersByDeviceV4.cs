// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// AdminGetUsersByDeviceV4
    ///
    /// This is the endpoint for an admin to get users that ever login on the device.
    /// 
    /// 
    /// 
    /// Required permission
    /// 
    /// 
    ///     'ADMIN:NAMESPACE:{namespace}:USER [READ]'
    /// </summary>
    public class AdminGetUsersByDeviceV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUsersByDeviceV4Builder Builder = new AdminGetUsersByDeviceV4Builder();

        public class AdminGetUsersByDeviceV4Builder
            : OperationBuilder<AdminGetUsersByDeviceV4Builder>
        {





            internal AdminGetUsersByDeviceV4Builder() { }






            public AdminGetUsersByDeviceV4 Build(
                string deviceId,
                string namespace_
            )
            {
                AdminGetUsersByDeviceV4 op = new AdminGetUsersByDeviceV4(this,
                    deviceId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetUsersByDeviceV4(AdminGetUsersByDeviceV4Builder builder,
            string deviceId,
            string namespace_
        )
        {
            PathParams["deviceId"] = deviceId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUsersByDeviceV4(
            string deviceId,
            string namespace_
        )
        {
            PathParams["deviceId"] = deviceId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/{deviceId}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelDeviceUsersResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceUsersResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceUsersResponseV4>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}