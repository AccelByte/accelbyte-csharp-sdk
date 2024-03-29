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
    /// AdminLinkPlatformAccount
    ///
    /// Force linking platform account to user User Account. This endpoint intended for admin to forcefully link account to user.
    /// By default, these cases are not allowed
    /// - The platform account current is linked by another account
    /// - The target account ever linked this platform's another account
    /// </summary>
    public class AdminLinkPlatformAccount : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminLinkPlatformAccountBuilder Builder { get => new AdminLinkPlatformAccountBuilder(); }

        public class AdminLinkPlatformAccountBuilder
            : OperationBuilder<AdminLinkPlatformAccountBuilder>
        {

            public bool? SkipConflict { get; set; }





            internal AdminLinkPlatformAccountBuilder() { }


            public AdminLinkPlatformAccountBuilder SetSkipConflict(bool _skipConflict)
            {
                SkipConflict = _skipConflict;
                return this;
            }





            public AdminLinkPlatformAccount Build(
                ModelLinkPlatformAccountRequest body,
                string namespace_,
                string userId
            )
            {
                AdminLinkPlatformAccount op = new AdminLinkPlatformAccount(this,
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

        private AdminLinkPlatformAccount(AdminLinkPlatformAccountBuilder builder,
            ModelLinkPlatformAccountRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (builder.SkipConflict != null) QueryParams["skipConflict"] = Convert.ToString(builder.SkipConflict)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminLinkPlatformAccount(
            string namespace_,
            string userId,
            bool? skipConflict,
            Model.ModelLinkPlatformAccountRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (skipConflict != null) QueryParams["skipConflict"] = Convert.ToString(skipConflict)!;




            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/link";

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