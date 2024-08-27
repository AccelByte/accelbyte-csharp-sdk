// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Lobby.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Lobby.Operation
{
    /// <summary>
    /// adminBulkUnblockPlayersV1
    ///
    /// Bulk unblock player in a namespace by list of user id
    /// </summary>
    public class AdminBulkUnblockPlayersV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminBulkUnblockPlayersV1Builder Builder { get => new AdminBulkUnblockPlayersV1Builder(); }

        public class AdminBulkUnblockPlayersV1Builder
            : OperationBuilder<AdminBulkUnblockPlayersV1Builder>
        {





            internal AdminBulkUnblockPlayersV1Builder() { }






            public AdminBulkUnblockPlayersV1 Build(
                ModelsListUnblockPlayerRequest body,
                string namespace_,
                string userId
            )
            {
                AdminBulkUnblockPlayersV1 op = new AdminBulkUnblockPlayersV1(this,
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

        private AdminBulkUnblockPlayersV1(AdminBulkUnblockPlayersV1Builder builder,
            ModelsListUnblockPlayerRequest body,
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

        public AdminBulkUnblockPlayersV1(
            string namespace_,
            string userId,
            Model.ModelsListUnblockPlayerRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/lobby/v1/admin/player/namespaces/{namespace}/users/{userId}/bulk/unblock";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}