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
    /// checkWallet
    ///
    ///  [SERVICE COMMUNICATION ONLY] Check wallet by balance origin and currency code whether it's inactive.
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class CheckWallet : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CheckWalletBuilder Builder { get => new CheckWalletBuilder(); }

        public class CheckWalletBuilder
            : OperationBuilder<CheckWalletBuilder>
        {





            internal CheckWalletBuilder() { }






            public CheckWallet Build(
                string currencyCode,
                string namespace_,
                string userId,
                CheckWalletOrigin origin
            )
            {
                CheckWallet op = new CheckWallet(this,
                    currencyCode,
                    namespace_,
                    userId,
                    origin
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CheckWallet(CheckWalletBuilder builder,
            string currencyCode,
            string namespace_,
            string userId,
            CheckWalletOrigin origin
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (origin is not null) QueryParams["origin"] = origin.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CheckWallet(
            string currencyCode,
            string namespace_,
            string userId,
            CheckWalletOrigin origin
        )
        {
            PathParams["currencyCode"] = currencyCode;
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;

            if (origin is not null) QueryParams["origin"] = origin.Value;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/platform/admin/namespaces/{namespace}/users/{userId}/wallets/{currencyCode}/check";

        public override HttpMethod Method => HttpMethod.Get;

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

    public class CheckWalletOrigin : StringEnum<CheckWalletOrigin>
    {
        public static readonly CheckWalletOrigin Epic
            = new CheckWalletOrigin("Epic");

        public static readonly CheckWalletOrigin GooglePlay
            = new CheckWalletOrigin("GooglePlay");

        public static readonly CheckWalletOrigin IOS
            = new CheckWalletOrigin("IOS");

        public static readonly CheckWalletOrigin Nintendo
            = new CheckWalletOrigin("Nintendo");

        public static readonly CheckWalletOrigin Oculus
            = new CheckWalletOrigin("Oculus");

        public static readonly CheckWalletOrigin Other
            = new CheckWalletOrigin("Other");

        public static readonly CheckWalletOrigin Playstation
            = new CheckWalletOrigin("Playstation");

        public static readonly CheckWalletOrigin Steam
            = new CheckWalletOrigin("Steam");

        public static readonly CheckWalletOrigin System
            = new CheckWalletOrigin("System");

        public static readonly CheckWalletOrigin Twitch
            = new CheckWalletOrigin("Twitch");

        public static readonly CheckWalletOrigin Xbox
            = new CheckWalletOrigin("Xbox");


        public static implicit operator CheckWalletOrigin(string value)
        {
            return NewValue(value);
        }

        public CheckWalletOrigin(string enumValue)
            : base(enumValue)
        {

        }
    }

}