// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// publicGetUserProfilePublicInfoByIds
    ///
    /// Get user public profile by ids.
    /// Other detail info:
    /// 
    ///   * Action code : 11405
    ///   *  Returns : user public profiles
    /// </summary>
    public class PublicGetUserProfilePublicInfoByIds : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUserProfilePublicInfoByIdsBuilder Builder { get => new PublicGetUserProfilePublicInfoByIdsBuilder(); }

        public class PublicGetUserProfilePublicInfoByIdsBuilder
            : OperationBuilder<PublicGetUserProfilePublicInfoByIdsBuilder>
        {





            internal PublicGetUserProfilePublicInfoByIdsBuilder() { }






            public PublicGetUserProfilePublicInfoByIds Build(
                string namespace_,
                string userIds
            )
            {
                PublicGetUserProfilePublicInfoByIds op = new PublicGetUserProfilePublicInfoByIds(this,
                    namespace_,
                    userIds
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetUserProfilePublicInfoByIds(PublicGetUserProfilePublicInfoByIdsBuilder builder,
            string namespace_,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (userIds is not null) QueryParams["userIds"] = userIds;






        }
        #endregion

        public PublicGetUserProfilePublicInfoByIds(
            string namespace_,
            string userIds
        )
        {
            PathParams["namespace"] = namespace_;

            if (userIds is not null) QueryParams["userIds"] = userIds;






        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/profiles/public";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.UserProfilePublicInfo>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public List<Model.UserProfilePublicInfo<T1>>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo<T1>>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.UserProfilePublicInfo<T1>>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}