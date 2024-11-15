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
    /// PublicGetMyProfileAllowUpdateStatusV3
    ///
    /// This API is for user to get self profile update allow status.
    /// Note: If the config is not found, this API will return a config with unlimited.
    /// </summary>
    public class PublicGetMyProfileAllowUpdateStatusV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyProfileAllowUpdateStatusV3Builder Builder { get => new PublicGetMyProfileAllowUpdateStatusV3Builder(); }

        public class PublicGetMyProfileAllowUpdateStatusV3Builder
            : OperationBuilder<PublicGetMyProfileAllowUpdateStatusV3Builder>
        {





            internal PublicGetMyProfileAllowUpdateStatusV3Builder() { }






            public PublicGetMyProfileAllowUpdateStatusV3 Build(
            )
            {
                PublicGetMyProfileAllowUpdateStatusV3 op = new PublicGetMyProfileAllowUpdateStatusV3(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetMyProfileAllowUpdateStatusV3(PublicGetMyProfileAllowUpdateStatusV3Builder builder
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetMyProfileAllowUpdateStatusV3(
        )
        {







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/users/me/profileStatus";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUserProfileUpdateAllowStatus? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelUserProfileUpdateAllowStatus>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelUserProfileUpdateAllowStatus>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserProfileUpdateAllowStatus>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}