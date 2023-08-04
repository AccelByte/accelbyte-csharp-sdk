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
    /// PublicUpdateUserV2
    ///
    /// 
    /// 
    /// ## The endpoint is going to be deprecated
    /// 
    /// 
    /// Endpoint migration guide
    /// 
    /// 
    ///             * Substitute endpoint([PUT]): /iam/v3/public/namespaces/{namespace}/users/me [PUT]
    /// 
    ///             * Substitute endpoint([PATCH]): /iam/v3/public/namespaces/{namespace}/users/me [PATCH]
    /// 
    ///             * Substitute endpoint([PATCH]): /iam/v4/public/namespaces/{namespace}/users/me [PATCH]
    /// 
    /// 
    /// 
    ///             * Note:
    ///     1. Prefer [PATCH] if client support PATCH method
    /// 
    ///     2. Difference in V3/v4 request body, format difference: Pascal case => Camel case
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This Endpoint support update user based on given data. Single request can update single field or multi fields.
    /// 
    /// "+
    /// "This endpoint require valid user access token to accessed.
    /// 
    /// Supported field {Country, DisplayName, LanguageTag}
    /// </summary>
    [Obsolete(DiagnosticId = "ab_deprecated_operation")]
    public class PublicUpdateUserV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateUserV2Builder Builder { get => new PublicUpdateUserV2Builder(); }

        public class PublicUpdateUserV2Builder
            : OperationBuilder<PublicUpdateUserV2Builder>
        {





            internal PublicUpdateUserV2Builder() { }






            public PublicUpdateUserV2 Build(
                ModelUserUpdateRequest body,
                string namespace_,
                string userId
            )
            {
                PublicUpdateUserV2 op = new PublicUpdateUserV2(this,
                    body,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicUpdateUserV2(PublicUpdateUserV2Builder builder,
            ModelUserUpdateRequest body,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }
        #endregion

        public PublicUpdateUserV2(
            string namespace_,
            string userId,
            Model.ModelUserUpdateRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BASIC);
        }

        public override string Path => "/iam/v2/public/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Basic";

        public List<Model.ModelUserResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<List<Model.ModelUserResponse>>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<List<Model.ModelUserResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelUserResponse>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}