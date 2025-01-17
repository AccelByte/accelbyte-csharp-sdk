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
    /// fulfillItemsV3
    ///
    /// [Not supported yet in AGS Shared Cloud] Fulfill items by transactionId.
    /// Other detail info:
    ///               * Request body : storeId, region, language, and entitlementCollectionId can be ignored.
    ///               *  Returns : fulfillment v2 result, storeId field can be ignored.
    /// </summary>
    public class FulfillItemsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static FulfillItemsV3Builder Builder { get => new FulfillItemsV3Builder(); }

        public class FulfillItemsV3Builder
            : OperationBuilder<FulfillItemsV3Builder>
        {





            internal FulfillItemsV3Builder() { }






            public FulfillItemsV3 Build(
                FulfillmentV2Request body,
                string namespace_,
                string transactionId,
                string userId
            )
            {
                FulfillItemsV3 op = new FulfillItemsV3(this,
                    body,
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

        private FulfillItemsV3(FulfillItemsV3Builder builder,
            FulfillmentV2Request body,
            string namespace_,
            string transactionId,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public FulfillItemsV3(
            string namespace_,
            string transactionId,
            string userId,
            Model.FulfillmentV2Request body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["transactionId"] = transactionId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/v3/admin/namespaces/{namespace}/users/{userId}/fulfillments/{transactionId}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.FulfillmentV2Result? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.FulfillmentV2Result>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.FulfillmentV2Result>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.FulfillmentV2Result>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}