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
    /// GetAdminInvitationV3
    ///
    /// Endpoint to validate user invitation. When not found, it could also means the invitation has expired.
    /// </summary>
    public class GetAdminInvitationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetAdminInvitationV3Builder Builder { get => new GetAdminInvitationV3Builder(); }

        public class GetAdminInvitationV3Builder
            : OperationBuilder<GetAdminInvitationV3Builder>
        {





            internal GetAdminInvitationV3Builder() { }






            public GetAdminInvitationV3 Build(
                string invitationId,
                string namespace_
            )
            {
                GetAdminInvitationV3 op = new GetAdminInvitationV3(this,
                    invitationId,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetAdminInvitationV3(GetAdminInvitationV3Builder builder,
            string invitationId,
            string namespace_
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetAdminInvitationV3(
            string invitationId,
            string namespace_
        )
        {
            PathParams["invitationId"] = invitationId;
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/invite/{invitationId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUserInvitationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserInvitationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserInvitationV3>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}