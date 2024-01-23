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
    /// PublicInviteUserV4
    ///
    /// This endpoint is used to invite a game studio admin user with new namespace in multi tenant mode.
    /// It will return error if the service multi tenant mode is set to false.
    /// 
    /// Request body details:
    /// - emailAddress: email address of the user to be invited
    /// - namespace: new namespace of the user to be created
    /// - namespaceDisplayName: display name of the new namespace
    /// - additionalData(optional): for utm parameter data
    /// 
    /// The invited users will also be assigned with "User" role by default.
    /// </summary>
    public class PublicInviteUserV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicInviteUserV4Builder Builder { get => new PublicInviteUserV4Builder(); }

        public class PublicInviteUserV4Builder
            : OperationBuilder<PublicInviteUserV4Builder>
        {





            internal PublicInviteUserV4Builder() { }






            public PublicInviteUserV4 Build(
                ModelPublicInviteUserRequestV4 body
            )
            {
                PublicInviteUserV4 op = new PublicInviteUserV4(this,
                    body
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicInviteUserV4(PublicInviteUserV4Builder builder,
            ModelPublicInviteUserRequestV4 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicInviteUserV4(
            Model.ModelPublicInviteUserRequestV4 body
        )
        {





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/users/invite";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelInviteUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInviteUserResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}