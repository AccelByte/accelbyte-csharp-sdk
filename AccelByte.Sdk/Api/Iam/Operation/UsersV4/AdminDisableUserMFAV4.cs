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
    /// AdminDisableUserMFAV4
    ///
    /// This endpoint is used to disable user 2FA.
    /// -----------
    /// **Note**: if the factor is not specified, will disable all 2FA methods.
    /// </summary>
    public class AdminDisableUserMFAV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDisableUserMFAV4Builder Builder { get => new AdminDisableUserMFAV4Builder(); }

        public class AdminDisableUserMFAV4Builder
            : OperationBuilder<AdminDisableUserMFAV4Builder>
        {





            internal AdminDisableUserMFAV4Builder() { }






            public AdminDisableUserMFAV4 Build(
                ModelDisableMFARequest body,
                string namespace_,
                string userId
            )
            {
                AdminDisableUserMFAV4 op = new AdminDisableUserMFAV4(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminDisableUserMFAV4(AdminDisableUserMFAV4Builder builder,
            ModelDisableMFARequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDisableUserMFAV4(
            string namespace_,
            string userId,
            Model.ModelDisableMFARequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/namespaces/{namespace}/users/{userId}/mfa/disable";

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