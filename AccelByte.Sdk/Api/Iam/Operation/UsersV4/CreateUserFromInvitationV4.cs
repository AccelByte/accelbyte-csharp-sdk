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
    /// CreateUserFromInvitationV4
    ///
    /// This endpoint create user from saved roles when creating invitation and submitted data.
    /// User will be able to login after completing submitting the data through this endpoint.
    /// Available Authentication Types:
    /// 
    /// EMAILPASSWD: an authentication type used for new user registration through email.
    /// 
    /// **Note**:
    /// * **uniqueDisplayName**: this is required when uniqueDisplayNameEnabled/UNIQUE_DISPLAY_NAME_ENABLED is true.
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// 
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// 
    /// Required attributes:
    /// - authType: possible value is EMAILPASSWD (see above)
    /// - country: ISO3166-1 alpha-2 two letter, e.g. US.
    /// - dateOfBirth: YYYY-MM-DD, e.g. 1990-01-01. valid values are between 1905-01-01 until current date.
    /// - displayName: Please refer to the rule from /v3/public/inputValidations API.
    /// - password: Please refer to the rule from /v3/public/inputValidations API.
    /// - username: Please refer to the rule from /v3/public/inputValidations API.
    /// </summary>
    public class CreateUserFromInvitationV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateUserFromInvitationV4Builder Builder { get => new CreateUserFromInvitationV4Builder(); }

        public class CreateUserFromInvitationV4Builder
            : OperationBuilder<CreateUserFromInvitationV4Builder>
        {





            internal CreateUserFromInvitationV4Builder() { }






            public CreateUserFromInvitationV4 Build(
                AccountCreateUserRequestV4 body,
                string invitationId,
                string namespace_
            )
            {
                CreateUserFromInvitationV4 op = new CreateUserFromInvitationV4(this,
                    body,
                    invitationId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateUserFromInvitationV4(CreateUserFromInvitationV4Builder builder,
            AccountCreateUserRequestV4 body,
            string invitationId,
            string namespace_
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateUserFromInvitationV4(
            string invitationId,
            string namespace_,
            Model.AccountCreateUserRequestV4 body
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/invite/{invitationId}";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.AccountCreateUserResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountCreateUserResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}