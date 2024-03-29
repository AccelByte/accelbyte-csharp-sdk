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
    /// AdminVerifyAccountV3
    ///
    /// Will verify account and consume code if validateOnly is set false in request body
    /// Redeems a verification code sent to a user to verify the user's contact address is correct
    /// Available ContactType : **email** or **phone**
    /// </summary>
    public class AdminVerifyAccountV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminVerifyAccountV3Builder Builder { get => new AdminVerifyAccountV3Builder(); }

        public class AdminVerifyAccountV3Builder
            : OperationBuilder<AdminVerifyAccountV3Builder>
        {





            internal AdminVerifyAccountV3Builder() { }






            public AdminVerifyAccountV3 Build(
                ModelUserVerificationRequest body,
                string namespace_,
                string userId
            )
            {
                AdminVerifyAccountV3 op = new AdminVerifyAccountV3(this,
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

        private AdminVerifyAccountV3(AdminVerifyAccountV3Builder builder,
            ModelUserVerificationRequest body,
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

        public AdminVerifyAccountV3(
            string namespace_,
            string userId,
            Model.ModelUserVerificationRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/code/verify";

        public override HttpMethod Method => HttpMethod.Post;

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