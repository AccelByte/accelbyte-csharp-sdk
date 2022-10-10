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
    /// AdminGetUserDeviceBansV4
    ///
    /// This is the endpoint for an admin to get device bans of user.
    /// 
    /// 
    /// 
    /// Required permission
    /// 
    /// 
    ///     'ADMIN:NAMESPACE:{namespace}:DEVICE [READ]'
    /// </summary>
    public class AdminGetUserDeviceBansV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserDeviceBansV4Builder Builder = new AdminGetUserDeviceBansV4Builder();

        public class AdminGetUserDeviceBansV4Builder
            : OperationBuilder<AdminGetUserDeviceBansV4Builder>
        {





            internal AdminGetUserDeviceBansV4Builder() { }






            public AdminGetUserDeviceBansV4 Build(
                string namespace_,
                string userId
            )
            {
                AdminGetUserDeviceBansV4 op = new AdminGetUserDeviceBansV4(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetUserDeviceBansV4(AdminGetUserDeviceBansV4Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserDeviceBansV4(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;

            if (userId is not null) QueryParams["userId"] = userId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/devices/bans";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelDeviceBansResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBansResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelDeviceBansResponseV4>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}