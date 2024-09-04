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
    /// PublicGetMyMFAStatusV4
    ///
    /// This endpoint will get user's' MFA status.
    /// ---------
    /// **Substitute endpoint**: /iam/v4/public/namespaces/{namespace}/users/me/mfa/status [GET]
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicGetMyMFAStatusV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetMyMFAStatusV4Builder Builder { get => new PublicGetMyMFAStatusV4Builder(); }

        public class PublicGetMyMFAStatusV4Builder
            : OperationBuilder<PublicGetMyMFAStatusV4Builder>
        {





            internal PublicGetMyMFAStatusV4Builder() { }






            public PublicGetMyMFAStatusV4 Build(
                string namespace_
            )
            {
                PublicGetMyMFAStatusV4 op = new PublicGetMyMFAStatusV4(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetMyMFAStatusV4(PublicGetMyMFAStatusV4Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetMyMFAStatusV4(
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/me/mfa/status";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUserMFAStatusResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelUserMFAStatusResponseV4>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelUserMFAStatusResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserMFAStatusResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}