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
    /// AdminEnableBackupCodesV4
    ///
    /// This endpoint is used to enable 2FA backup codes.
    /// </summary>
    public class AdminEnableBackupCodesV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminEnableBackupCodesV4Builder Builder { get => new AdminEnableBackupCodesV4Builder(); }

        public class AdminEnableBackupCodesV4Builder
            : OperationBuilder<AdminEnableBackupCodesV4Builder>
        {

            public string? LanguageTag { get; set; }





            internal AdminEnableBackupCodesV4Builder() { }


            public AdminEnableBackupCodesV4Builder SetLanguageTag(string _languageTag)
            {
                LanguageTag = _languageTag;
                return this;
            }





            public AdminEnableBackupCodesV4 Build(
            )
            {
                AdminEnableBackupCodesV4 op = new AdminEnableBackupCodesV4(this
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private AdminEnableBackupCodesV4(AdminEnableBackupCodesV4Builder builder
        )
        {

            if (builder.LanguageTag is not null) QueryParams["languageTag"] = builder.LanguageTag;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminEnableBackupCodesV4(
            string? languageTag
        )
        {

            if (languageTag is not null) QueryParams["languageTag"] = languageTag;






            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/admin/users/me/mfa/backupCodes/enable";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)200)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}