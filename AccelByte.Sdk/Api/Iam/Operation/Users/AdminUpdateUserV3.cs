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
    /// AdminUpdateUserV3
    ///
    /// This Endpoint support update user based on given data. **Single request can update single field or multi fields.**
    /// Supported field {country, displayName, languageTag, dateOfBirth, avatarUrl, userName, tags}
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// Admin can set Tags with array string data e.g. ["10e9a46ef6164b7e86d08e86605bd8cf"].
    /// Admin also can reset user tags by sending empty array string e.g. [ ].
    /// Users can have at most 5 tags. No duplicate tags allowed.
    /// 
    /// **Response body logic when user updating email address:**
    /// - User want to update email address of which have been verified, NewEmailAddress response field will be filled with new email address.
    /// - User want to update email address of which have not been verified, {LoginId, OldEmailAddress, EmailAddress} response field will be filled with new email address.
    /// - User want to update email address of which have been verified and updated before, {LoginId, OldEmailAddress, EmailAddress} response field will be filled with verified email before. NewEmailAddress response field will be filled with newest email address.
    /// 
    /// action code : 10103
    /// </summary>
    public class AdminUpdateUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateUserV3Builder Builder { get => new AdminUpdateUserV3Builder(); }

        public class AdminUpdateUserV3Builder
            : OperationBuilder<AdminUpdateUserV3Builder>
        {





            internal AdminUpdateUserV3Builder() { }






            public AdminUpdateUserV3 Build(
                ModelUserUpdateRequestV3 body,
                string namespace_,
                string userId
            )
            {
                AdminUpdateUserV3 op = new AdminUpdateUserV3(this,
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

        private AdminUpdateUserV3(AdminUpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
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

        public AdminUpdateUserV3(
            string namespace_,
            string userId,
            Model.ModelUserUpdateRequestV3 body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}