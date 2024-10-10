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
    /// publicFulfillAppleIAPItem
    ///
    /// Verify apple iap receipt and fulfill item. don't support subscriptionOther detail info:
    ///   * Returns :
    /// </summary>
    public class PublicFulfillAppleIAPItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicFulfillAppleIAPItemBuilder Builder { get => new PublicFulfillAppleIAPItemBuilder(); }

        public class PublicFulfillAppleIAPItemBuilder
            : OperationBuilder<PublicFulfillAppleIAPItemBuilder>
        {





            internal PublicFulfillAppleIAPItemBuilder() { }






            public PublicFulfillAppleIAPItem Build(
                AppleIAPReceipt body,
                string namespace_,
                string userId
            )
            {
                PublicFulfillAppleIAPItem op = new PublicFulfillAppleIAPItem(this,
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

        private PublicFulfillAppleIAPItem(PublicFulfillAppleIAPItemBuilder builder,
            AppleIAPReceipt body,
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

        public PublicFulfillAppleIAPItem(
            string namespace_,
            string userId,
            Model.AppleIAPReceipt body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/public/namespaces/{namespace}/users/{userId}/iap/apple/receipt";

        public override HttpMethod Method => HttpMethod.Put;

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