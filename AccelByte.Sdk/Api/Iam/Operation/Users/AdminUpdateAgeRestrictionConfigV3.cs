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
    /// AdminUpdateAgeRestrictionConfigV3
    ///
    /// action code: 10122
    /// </summary>
    public class AdminUpdateAgeRestrictionConfigV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminUpdateAgeRestrictionConfigV3Builder Builder { get => new AdminUpdateAgeRestrictionConfigV3Builder(); }

        public class AdminUpdateAgeRestrictionConfigV3Builder
            : OperationBuilder<AdminUpdateAgeRestrictionConfigV3Builder>
        {





            internal AdminUpdateAgeRestrictionConfigV3Builder() { }






            public AdminUpdateAgeRestrictionConfigV3 Build(
                ModelAgeRestrictionRequestV3 body,
                string namespace_
            )
            {
                AdminUpdateAgeRestrictionConfigV3 op = new AdminUpdateAgeRestrictionConfigV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private AdminUpdateAgeRestrictionConfigV3(AdminUpdateAgeRestrictionConfigV3Builder builder,
            ModelAgeRestrictionRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminUpdateAgeRestrictionConfigV3(
            string namespace_,
            Model.ModelAgeRestrictionRequestV3 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/agerestrictions";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelAgeRestrictionResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelAgeRestrictionResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelAgeRestrictionResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelAgeRestrictionResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}