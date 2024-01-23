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
    /// adminQueryPlayerAttributes
    ///
    /// Admin get attributes of players.
    /// 
    /// Field descriptions:
    /// - userID : user who owns the attributes.
    /// - crossplayEnabled : set to true if the player wants to enable crossplay to their session (default: false).
    /// - platforms : list of the player's 3rd party platform account information.
    /// - name : platform name. supported platforms: STEAM, XBOX, PSN
    /// - userID : platform userID
    /// - data : other data that the player wants to store.
    /// - PSN_PUSH_CONTEXT_ID: if provided, session will refer to this when performing session sync with PSN, otherwise will populate from session attributes, otherwise will populate from session attributes
    /// - currentPlatform : latest user game platform.
    /// - roles : user role for matchmaking role base support.
    /// </summary>
    public class AdminQueryPlayerAttributes : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminQueryPlayerAttributesBuilder Builder { get => new AdminQueryPlayerAttributesBuilder(); }

        public class AdminQueryPlayerAttributesBuilder
            : OperationBuilder<AdminQueryPlayerAttributesBuilder>
        {

            public string? Users { get; set; }





            internal AdminQueryPlayerAttributesBuilder() { }


            public AdminQueryPlayerAttributesBuilder SetUsers(string _users)
            {
                Users = _users;
                return this;
            }





            public AdminQueryPlayerAttributes Build(
                string namespace_
            )
            {
                AdminQueryPlayerAttributes op = new AdminQueryPlayerAttributes(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminQueryPlayerAttributes(AdminQueryPlayerAttributesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Users is not null) QueryParams["users"] = builder.Users;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminQueryPlayerAttributes(
            string namespace_,
            string? users
        )
        {
            PathParams["namespace"] = namespace_;

            if (users is not null) QueryParams["users"] = users;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/users/attributes";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ApimodelsPlayerAttributesResponseBody>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ApimodelsPlayerAttributesResponseBody>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ApimodelsPlayerAttributesResponseBody>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsPlayerAttributesResponseBody>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.ApimodelsPlayerAttributesResponseBody<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsPlayerAttributesResponseBody<T1>>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ApimodelsPlayerAttributesResponseBody<T1>>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}