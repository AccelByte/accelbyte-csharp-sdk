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
    /// AdminUnbanDeviceV4
    ///
    /// This is the endpoint for an admin to unban device
    /// </summary>
    public class AdminUnbanDeviceV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUnbanDeviceV4Builder Builder { get => new AdminUnbanDeviceV4Builder(); }

        public class AdminUnbanDeviceV4Builder
            : OperationBuilder<AdminUnbanDeviceV4Builder>
        {





            internal AdminUnbanDeviceV4Builder() { }






            public AdminUnbanDeviceV4 Build(
                string deviceId,
                string namespace_
            )
            {
                AdminUnbanDeviceV4 op = new AdminUnbanDeviceV4(this,
                    deviceId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUnbanDeviceV4(AdminUnbanDeviceV4Builder builder,
            string deviceId,
            string namespace_
        )
        {
            PathParams["deviceId"] = deviceId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUnbanDeviceV4(
            string deviceId,
            string namespace_
        )
        {
            PathParams["deviceId"] = deviceId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/{deviceId}/unban";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { };

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