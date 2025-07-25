// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminUpdateGameSessionMember
    ///
    /// Update a game session member status.
    /// </summary>
    public class AdminUpdateGameSessionMember : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateGameSessionMemberBuilder Builder { get => new AdminUpdateGameSessionMemberBuilder(); }

        public class AdminUpdateGameSessionMemberBuilder
            : OperationBuilder<AdminUpdateGameSessionMemberBuilder>
        {





            internal AdminUpdateGameSessionMemberBuilder() { }






            public AdminUpdateGameSessionMember Build(
                string memberId,
                string namespace_,
                string sessionId,
                string statusType
            )
            {
                AdminUpdateGameSessionMember op = new AdminUpdateGameSessionMember(this,
                    memberId,
                    namespace_,
                    sessionId,
                    statusType
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminUpdateGameSessionMember(AdminUpdateGameSessionMemberBuilder builder,
            string memberId,
            string namespace_,
            string sessionId,
            string statusType
        )
        {
            PathParams["memberId"] = memberId;
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["statusType"] = statusType;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateGameSessionMember(
            string memberId,
            string namespace_,
            string sessionId,
            string statusType
        )
        {
            PathParams["memberId"] = memberId;
            PathParams["namespace"] = namespace_;
            PathParams["sessionId"] = sessionId;
            PathParams["statusType"] = statusType;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/gamesessions/{sessionId}/members/{memberId}/status/{statusType}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsUpdateGameSessionMemberStatusResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsUpdateGameSessionMemberStatusResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsUpdateGameSessionMemberStatusResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsUpdateGameSessionMemberStatusResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}