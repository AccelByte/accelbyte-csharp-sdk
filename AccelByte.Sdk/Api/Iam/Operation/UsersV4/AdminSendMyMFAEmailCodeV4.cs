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
    /// AdminSendMyMFAEmailCodeV4
    ///
    /// This endpoint is used to send email code.
    /// </summary>
    public class AdminSendMyMFAEmailCodeV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSendMyMFAEmailCodeV4Builder Builder { get => new AdminSendMyMFAEmailCodeV4Builder(); }

        public class AdminSendMyMFAEmailCodeV4Builder
            : OperationBuilder<AdminSendMyMFAEmailCodeV4Builder>
        {





            internal AdminSendMyMFAEmailCodeV4Builder() { }






            public AdminSendMyMFAEmailCodeV4 Build(
            )
            {
                AdminSendMyMFAEmailCodeV4 op = new AdminSendMyMFAEmailCodeV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminSendMyMFAEmailCodeV4(AdminSendMyMFAEmailCodeV4Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSendMyMFAEmailCodeV4(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/email/code";

        public override HttpMethod Method => HttpMethod.Post;

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