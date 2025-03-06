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
    /// syncSteamAbnormalTransaction
    /// </summary>
    public class SyncSteamAbnormalTransaction : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static SyncSteamAbnormalTransactionBuilder Builder { get => new SyncSteamAbnormalTransactionBuilder(); }

        public class SyncSteamAbnormalTransactionBuilder
            : OperationBuilder<SyncSteamAbnormalTransactionBuilder>
        {





            internal SyncSteamAbnormalTransactionBuilder() { }






            public SyncSteamAbnormalTransaction Build(
                string namespace_,
                string userId
            )
            {
                SyncSteamAbnormalTransaction op = new SyncSteamAbnormalTransaction(this,
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

        private SyncSteamAbnormalTransaction(SyncSteamAbnormalTransactionBuilder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public SyncSteamAbnormalTransaction(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/steam/syncAbnormalTransaction";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.IAPOrderShortInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.IAPOrderShortInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.IAPOrderShortInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.IAPOrderShortInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}