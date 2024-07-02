// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Challenge.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Challenge.Operation
{
    /// <summary>
    /// adminClaimUsersRewards
    ///
    /// 
    ///     * Required permission: ADMIN:NAMESPACE:{namespace}:CHALLENGE:REWARD [UPDATE]
    /// </summary>
    public class AdminClaimUsersRewards : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminClaimUsersRewardsBuilder Builder { get => new AdminClaimUsersRewardsBuilder(); }

        public class AdminClaimUsersRewardsBuilder
            : OperationBuilder<AdminClaimUsersRewardsBuilder>
        {





            internal AdminClaimUsersRewardsBuilder() { }






            public AdminClaimUsersRewards Build(
                List<ModelClaimUsersRewardsRequest> body,
                string namespace_
            )
            {
                AdminClaimUsersRewards op = new AdminClaimUsersRewards(this,
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

        private AdminClaimUsersRewards(AdminClaimUsersRewardsBuilder builder,
            List<ModelClaimUsersRewardsRequest> body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminClaimUsersRewards(
            string namespace_,
            List<Model.ModelClaimUsersRewardsRequest> body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/challenge/v1/admin/namespaces/{namespace}/users/rewards/claim";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.ModelClaimUsersRewardsResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelClaimUsersRewardsResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelClaimUsersRewardsResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelClaimUsersRewardsResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}