// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// deleteBulkLeaderboardConfigurationAdminV3
    ///
    /// 
    /// 
    /// This endpoint delete multiple leaderboards configuration in one request
    /// </summary>
    public class DeleteBulkLeaderboardConfigurationAdminV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static DeleteBulkLeaderboardConfigurationAdminV3Builder Builder { get => new DeleteBulkLeaderboardConfigurationAdminV3Builder(); }

        public class DeleteBulkLeaderboardConfigurationAdminV3Builder
            : OperationBuilder<DeleteBulkLeaderboardConfigurationAdminV3Builder>
        {





            internal DeleteBulkLeaderboardConfigurationAdminV3Builder() { }






            public DeleteBulkLeaderboardConfigurationAdminV3 Build(
                ModelsDeleteBulkLeaderboardsReq body,
                string namespace_
            )
            {
                DeleteBulkLeaderboardConfigurationAdminV3 op = new DeleteBulkLeaderboardConfigurationAdminV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private DeleteBulkLeaderboardConfigurationAdminV3(DeleteBulkLeaderboardConfigurationAdminV3Builder builder,
            ModelsDeleteBulkLeaderboardsReq body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public DeleteBulkLeaderboardConfigurationAdminV3(
            string namespace_,
            Model.ModelsDeleteBulkLeaderboardsReq body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v3/admin/namespaces/{namespace}/leaderboards/delete";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelsDeleteBulkLeaderboardsResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelsDeleteBulkLeaderboardsResp>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelsDeleteBulkLeaderboardsResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsDeleteBulkLeaderboardsResp>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}