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
    /// adminGetMemberActiveSession
    ///
    /// 
    /// Get Member Active Session.
    /// </summary>
    public class AdminGetMemberActiveSession : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetMemberActiveSessionBuilder Builder { get => new AdminGetMemberActiveSessionBuilder(); }

        public class AdminGetMemberActiveSessionBuilder
            : OperationBuilder<AdminGetMemberActiveSessionBuilder>
        {





            internal AdminGetMemberActiveSessionBuilder() { }






            public AdminGetMemberActiveSession Build(
                string name,
                string namespace_,
                string userId
            )
            {
                AdminGetMemberActiveSession op = new AdminGetMemberActiveSession(this,
                    name,
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

        private AdminGetMemberActiveSession(AdminGetMemberActiveSessionBuilder builder,
            string name,
            string namespace_,
            string userId
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetMemberActiveSession(
            string name,
            string namespace_,
            string userId
        )
        {
            PathParams["name"] = name;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/configurations/{name}/memberactivesession/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsMemberActiveSession? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsMemberActiveSession>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsMemberActiveSession>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsMemberActiveSession>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}