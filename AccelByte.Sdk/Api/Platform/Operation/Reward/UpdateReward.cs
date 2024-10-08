// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Platform.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Platform.Operation
{
    /// <summary>
    /// updateReward
    ///
    /// This API is used to update a reward.
    /// Other detail info:
    /// 
    ///   * Returns : reward instance
    ///   *  Acceptable values for rewardItem's identityType are : ITEM_ID or ITEM_SKU
    /// </summary>
    public class UpdateReward : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateRewardBuilder Builder { get => new UpdateRewardBuilder(); }

        public class UpdateRewardBuilder
            : OperationBuilder<UpdateRewardBuilder>
        {





            internal UpdateRewardBuilder() { }






            public UpdateReward Build(
                RewardUpdate body,
                string namespace_,
                string rewardId
            )
            {
                UpdateReward op = new UpdateReward(this,
                    body,
                    namespace_,
                    rewardId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private UpdateReward(UpdateRewardBuilder builder,
            RewardUpdate body,
            string namespace_,
            string rewardId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public UpdateReward(
            string namespace_,
            string rewardId,
            Model.RewardUpdate body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["rewardId"] = rewardId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/rewards/{rewardId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RewardInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RewardInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RewardInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RewardInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}