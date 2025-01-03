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
    /// AdminGetUserLinkHistoriesV3
    ///
    /// This API is for admin to get user's link history.
    /// 
    /// **Supported Platforms:**
    /// - Steam group (steamnetwork):
    /// - steam
    /// - steamopenid
    /// - PSN group (psn):
    /// - ps4web
    /// - ps4
    /// - ps5
    /// - XBOX group(xbox):
    /// - live
    /// - xblweb
    /// - Oculus group (oculusgroup):
    /// - oculus
    /// - oculusweb
    /// - Google group (google):
    /// - google
    /// - googleplaygames:
    /// - epicgames
    /// - facebook
    /// - twitch
    /// - discord
    /// - android
    /// - ios
    /// - apple
    /// - device
    /// - nintendo
    /// - awscognito
    /// - amazon
    /// - netflix
    /// - snapchat
    /// - _oidc platform id_
    /// 
    /// Note:
    /// - You can use either platform id or platform group as **platformId** parameter.
    /// - **Nintendo platform user id**: NSA ID need to be appended with Environment ID using colon as separator. e.g kmzwa8awaa:dd1
    /// </summary>
    public class AdminGetUserLinkHistoriesV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetUserLinkHistoriesV3Builder Builder { get => new AdminGetUserLinkHistoriesV3Builder(); }

        public class AdminGetUserLinkHistoriesV3Builder
            : OperationBuilder<AdminGetUserLinkHistoriesV3Builder>
        {





            internal AdminGetUserLinkHistoriesV3Builder() { }






            public AdminGetUserLinkHistoriesV3 Build(
                string namespace_,
                string userId,
                string platformId
            )
            {
                AdminGetUserLinkHistoriesV3 op = new AdminGetUserLinkHistoriesV3(this,
                    namespace_,
                    userId,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGetUserLinkHistoriesV3(AdminGetUserLinkHistoriesV3Builder builder,
            string namespace_,
            string userId,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (platformId is not null) QueryParams["platformId"] = platformId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetUserLinkHistoriesV3(
            string namespace_,
            string userId,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (platformId is not null) QueryParams["platformId"] = platformId;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/{userId}/platforms/link/histories";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUserPlatformLinkHistories? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelUserPlatformLinkHistories>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelUserPlatformLinkHistories>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserPlatformLinkHistories>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}