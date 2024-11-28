// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Session.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Session.Operation
{
    /// <summary>
    /// adminDeletePlatformCredentialsByPlatformId
    ///
    /// Delete platform credentials for specific platform used for Native Session sync. Supported platforms: XBOX, PSN
    /// </summary>
    public class AdminDeletePlatformCredentialsByPlatformId : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminDeletePlatformCredentialsByPlatformIdBuilder Builder { get => new AdminDeletePlatformCredentialsByPlatformIdBuilder(); }

        public class AdminDeletePlatformCredentialsByPlatformIdBuilder
            : OperationBuilder<AdminDeletePlatformCredentialsByPlatformIdBuilder>
        {





            internal AdminDeletePlatformCredentialsByPlatformIdBuilder() { }






            public AdminDeletePlatformCredentialsByPlatformId Build(
                string namespace_,
                AdminDeletePlatformCredentialsByPlatformIdPlatformId platformId
            )
            {
                AdminDeletePlatformCredentialsByPlatformId op = new AdminDeletePlatformCredentialsByPlatformId(this,
                    namespace_,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminDeletePlatformCredentialsByPlatformId(AdminDeletePlatformCredentialsByPlatformIdBuilder builder,
            string namespace_,
            AdminDeletePlatformCredentialsByPlatformIdPlatformId platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId.Value;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminDeletePlatformCredentialsByPlatformId(
            string namespace_,
            AdminDeletePlatformCredentialsByPlatformIdPlatformId platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId.Value;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/session/v1/admin/namespaces/{namespace}/platform-credentials/{platformId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { };

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

    public class AdminDeletePlatformCredentialsByPlatformIdPlatformId : StringEnum<AdminDeletePlatformCredentialsByPlatformIdPlatformId>
    {
        public static readonly AdminDeletePlatformCredentialsByPlatformIdPlatformId PSN
            = new AdminDeletePlatformCredentialsByPlatformIdPlatformId("PSN");

        public static readonly AdminDeletePlatformCredentialsByPlatformIdPlatformId XBOX
            = new AdminDeletePlatformCredentialsByPlatformIdPlatformId("XBOX");


        public static implicit operator AdminDeletePlatformCredentialsByPlatformIdPlatformId(string value)
        {
            return NewValue(value);
        }

        public AdminDeletePlatformCredentialsByPlatformIdPlatformId(string enumValue)
            : base(enumValue)
        {

        }
    }

}