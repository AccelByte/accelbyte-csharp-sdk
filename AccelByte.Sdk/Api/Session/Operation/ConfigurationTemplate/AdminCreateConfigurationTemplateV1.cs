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
    /// adminCreateConfigurationTemplateV1
    ///
    /// Create template configuration to be applied across party and session.
    /// Session configuration mandatory :
    /// - name
    /// - joinability (example value : OPEN, CLOSED, INVITE_ONLY)
    /// - Type (example value : P2P, DS, NONE) if type empty, type will be assign to NONE
    /// - MinPlayers (must greather or equal 0)
    /// - MaxPlayers (must greather than 0)
    /// - InviteTimeout (must greather or equal 0) if InviteTimeout equal 0 will be use default DefaultTimeoutSecond (60s)
    /// - InactiveTimeout (must greather or equal 0) if InactiveTimeout equal 0 will be use default DefaultTimeoutSecond (60s)
    /// - Persistent Flag only can use with type DS (example value true or false)
    /// - If Persistent True the session always active even DS removing or terminate and Session will be request DS again until DS Ready or Busy.
    /// - To Stop Session Not request again to DS or want Delete Session can Delete Session using endpoint DELETE /session/v1/public/namespaces/{namespace}/gamesessions/{sessionId}
    /// - If Persistent False the session will be inactive if all member left and DS terminate or removing
    /// - nativeSessionSetting:
    /// - XboxSessionTemplateName: the XBox session template name that correspondent to the AB session template, and is needed to define XBox session's joinRestriction and maxMembersCount when doing the session sync.
    /// - XboxServiceConfigID: the XBox service configuration ID.
    /// - PSNServiceLabel: the PSN service label.
    /// - SessionTitle: the session title. In PSN, this will be used to define name of the session thats displayed on PlayStation system UI.
    /// - ShouldSync: to define whether the service needs to do session sync with native platform(s). Default: false (disabled).
    /// - PSNSupportedPlatforms: the PSN supported platforms. In PSN, if ShouldSync true and PSNSupportedPlatforms is empty, then PS5 will be set as default value.
    /// </summary>
    public class AdminCreateConfigurationTemplateV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminCreateConfigurationTemplateV1Builder Builder { get => new AdminCreateConfigurationTemplateV1Builder(); }

        public class AdminCreateConfigurationTemplateV1Builder
            : OperationBuilder<AdminCreateConfigurationTemplateV1Builder>
        {





            internal AdminCreateConfigurationTemplateV1Builder() { }






            public AdminCreateConfigurationTemplateV1 Build(
                ApimodelsCreateConfigurationTemplateRequest body,
                string namespace_
            )
            {
                AdminCreateConfigurationTemplateV1 op = new AdminCreateConfigurationTemplateV1(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminCreateConfigurationTemplateV1(AdminCreateConfigurationTemplateV1Builder builder,
            ApimodelsCreateConfigurationTemplateRequest body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminCreateConfigurationTemplateV1(
            string namespace_,
            Model.ApimodelsCreateConfigurationTemplateRequest body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/configuration";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsConfigurationTemplateResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsConfigurationTemplateResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}