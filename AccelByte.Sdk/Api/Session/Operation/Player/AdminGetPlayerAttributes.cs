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
    /// adminGetPlayerAttributes
    ///
    /// Admin get attributes of a player.
    /// 
    /// Field descriptions:
    /// - userID : user who owns the attributes.
    /// - crossplayEnabled : set to true if the player wants to enable crossplay to their session (default: false).
    /// - platforms : list of the player's 3rd party platform account information.
    /// - name : platform name. supported platforms: STEAM, XBOX, PSN
    /// - userID : platform userID
    /// - data : other data that the player wants to store.
    /// - currentPlatform : latest user game platform.
    /// - roles : user role for matchmaking role base support.
    /// </summary>
    public class AdminGetPlayerAttributes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetPlayerAttributesBuilder Builder { get => new AdminGetPlayerAttributesBuilder(); }

        public class AdminGetPlayerAttributesBuilder
            : OperationBuilder<AdminGetPlayerAttributesBuilder>
        {





            internal AdminGetPlayerAttributesBuilder() { }






            public AdminGetPlayerAttributes Build(
                string namespace_,
                string userId
            )
            {
                AdminGetPlayerAttributes op = new AdminGetPlayerAttributes(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminGetPlayerAttributes(AdminGetPlayerAttributesBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetPlayerAttributes(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/users/{userId}/attributes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ApimodelsPlayerAttributesResponseBody? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ApimodelsPlayerAttributesResponseBody<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ApimodelsPlayerAttributesResponseBody<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}