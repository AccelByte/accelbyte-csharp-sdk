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
    /// AdminGetDeviceBanV4
    ///
    /// This is the endpoint for an admin to get device ban config
    /// </summary>
    public class AdminGetDeviceBanV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetDeviceBanV4Builder Builder { get => new AdminGetDeviceBanV4Builder(); }

        public class AdminGetDeviceBanV4Builder
            : OperationBuilder<AdminGetDeviceBanV4Builder>
        {





            internal AdminGetDeviceBanV4Builder() { }






            public AdminGetDeviceBanV4 Build(
                string banId,
                string namespace_
            )
            {
                AdminGetDeviceBanV4 op = new AdminGetDeviceBanV4(this,
                    banId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetDeviceBanV4(AdminGetDeviceBanV4Builder builder,
            string banId,
            string namespace_
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetDeviceBanV4(
            string banId,
            string namespace_
        )
        {
            PathParams["banId"] = banId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/bans/{banId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelDeviceBanResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelDeviceBanResponseV4>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelDeviceBanResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBanResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}