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
    /// revokeItems
    ///
    ///  [Not supported yet in AGS Shared Cloud] Revoke items by transactionId.
    /// Other detail info:
    /// 
    ///   * Returns : revoke fulfillment v2 result, storeId field can be ignored.
    /// </summary>
    public class RevokeItems : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RevokeItemsBuilder Builder { get => new RevokeItemsBuilder(); }

        public class RevokeItemsBuilder
            : OperationBuilder<RevokeItemsBuilder>
        {





            internal RevokeItemsBuilder() { }






            public RevokeItems Build(
                string namespace_,
                string transactionId,
                string userId
            )
            {
                RevokeItems op = new RevokeItems(this,
                    namespace_,
                    transactionId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RevokeItems(RevokeItemsBuilder builder,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RevokeItems(
            string namespace_,
            string transactionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v2/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}/revoke";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RevokeFulfillmentV2Result? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.RevokeFulfillmentV2Result>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.RevokeFulfillmentV2Result>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RevokeFulfillmentV2Result>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}