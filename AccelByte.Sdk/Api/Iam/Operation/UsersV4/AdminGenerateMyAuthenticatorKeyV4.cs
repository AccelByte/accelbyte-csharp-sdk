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
    /// AdminGenerateMyAuthenticatorKeyV4
    ///
    /// This endpoint is used to generate a secret key for 3rd-party authenticator app.
    /// A QR code URI is also returned so that frontend can generate QR code image.
    /// </summary>
    public class AdminGenerateMyAuthenticatorKeyV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGenerateMyAuthenticatorKeyV4Builder Builder { get => new AdminGenerateMyAuthenticatorKeyV4Builder(); }

        public class AdminGenerateMyAuthenticatorKeyV4Builder
            : OperationBuilder<AdminGenerateMyAuthenticatorKeyV4Builder>
        {





            internal AdminGenerateMyAuthenticatorKeyV4Builder() { }






            public AdminGenerateMyAuthenticatorKeyV4 Build(
            )
            {
                AdminGenerateMyAuthenticatorKeyV4 op = new AdminGenerateMyAuthenticatorKeyV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminGenerateMyAuthenticatorKeyV4(AdminGenerateMyAuthenticatorKeyV4Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGenerateMyAuthenticatorKeyV4(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/authenticator/key";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelAuthenticatorKeyResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelAuthenticatorKeyResponseV4>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelAuthenticatorKeyResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelAuthenticatorKeyResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}