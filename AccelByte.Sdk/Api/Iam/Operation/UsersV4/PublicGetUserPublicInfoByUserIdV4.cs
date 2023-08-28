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
    /// PublicGetUserPublicInfoByUserIdV4
    ///
    /// 
    /// 
    /// This endpoint requires a valid user token and only returns user's public information.
    /// 
    /// action code: 10129
    /// </summary>
    public class PublicGetUserPublicInfoByUserIdV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserPublicInfoByUserIdV4Builder Builder { get => new PublicGetUserPublicInfoByUserIdV4Builder(); }

        public class PublicGetUserPublicInfoByUserIdV4Builder
            : OperationBuilder<PublicGetUserPublicInfoByUserIdV4Builder>
        {





            internal PublicGetUserPublicInfoByUserIdV4Builder() { }






            public PublicGetUserPublicInfoByUserIdV4 Build(
                string namespace_,
                string userId
            )
            {
                PublicGetUserPublicInfoByUserIdV4 op = new PublicGetUserPublicInfoByUserIdV4(this,
                    namespace_,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicGetUserPublicInfoByUserIdV4(PublicGetUserPublicInfoByUserIdV4Builder builder,
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUserPublicInfoByUserIdV4(
            string namespace_,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/public/namespaces/{namespace}/users/{userId}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUserPublicInfoResponseV4? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelUserPublicInfoResponseV4>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelUserPublicInfoResponseV4>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserPublicInfoResponseV4>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}