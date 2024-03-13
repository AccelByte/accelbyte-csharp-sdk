// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Ugc.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Ugc.Operation
{
    /// <summary>
    /// AdminDeleteContentByShareCodeV2
    ///
    /// Delete content by share code
    /// </summary>
    public class AdminDeleteContentByShareCodeV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeleteContentByShareCodeV2Builder Builder { get => new AdminDeleteContentByShareCodeV2Builder(); }

        public class AdminDeleteContentByShareCodeV2Builder
            : OperationBuilder<AdminDeleteContentByShareCodeV2Builder>
        {





            internal AdminDeleteContentByShareCodeV2Builder() { }






            public AdminDeleteContentByShareCodeV2 Build(
                string channelId,
                string namespace_,
                string shareCode,
                string userId
            )
            {
                AdminDeleteContentByShareCodeV2 op = new AdminDeleteContentByShareCodeV2(this,
                    channelId,
                    namespace_,
                    shareCode,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminDeleteContentByShareCodeV2(AdminDeleteContentByShareCodeV2Builder builder,
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeleteContentByShareCodeV2(
            string channelId,
            string namespace_,
            string shareCode,
            string userId
        )
        {
            PathParams["channelId"] = channelId;
            PathParams["namespace"] = namespace_;
            PathParams["shareCode"] = shareCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/ugc/v2/admin/namespaces/{namespace}/users/{userId}/channels/{channelId}/contents/sharecodes/{shareCode}";

        public override HttpMethod Method => HttpMethod.Delete;

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