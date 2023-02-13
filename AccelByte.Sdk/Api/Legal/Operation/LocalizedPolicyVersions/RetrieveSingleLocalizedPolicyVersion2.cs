// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Legal.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Legal.Operation
{
    /// <summary>
    /// retrieveSingleLocalizedPolicyVersion_2
    ///
    /// Retrieve specific localized policy version including the policy version and base policy version where the localized policy version located.
    /// Other detail info:
    /// </summary>
    public class RetrieveSingleLocalizedPolicyVersion2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RetrieveSingleLocalizedPolicyVersion2Builder Builder { get => new RetrieveSingleLocalizedPolicyVersion2Builder(); }

        public class RetrieveSingleLocalizedPolicyVersion2Builder
            : OperationBuilder<RetrieveSingleLocalizedPolicyVersion2Builder>
        {





            internal RetrieveSingleLocalizedPolicyVersion2Builder() { }






            public RetrieveSingleLocalizedPolicyVersion2 Build(
                string localizedPolicyVersionId
            )
            {
                RetrieveSingleLocalizedPolicyVersion2 op = new RetrieveSingleLocalizedPolicyVersion2(this,
                    localizedPolicyVersionId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private RetrieveSingleLocalizedPolicyVersion2(RetrieveSingleLocalizedPolicyVersion2Builder builder,
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;







        }
        #endregion

        public RetrieveSingleLocalizedPolicyVersion2(
            string localizedPolicyVersionId
        )
        {
            PathParams["localizedPolicyVersionId"] = localizedPolicyVersionId;







        }

        public override string Path => "/agreement/public/localized-policy-versions/{localizedPolicyVersionId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.RetrieveLocalizedPolicyVersionPublicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.RetrieveLocalizedPolicyVersionPublicResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.RetrieveLocalizedPolicyVersionPublicResponse>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}