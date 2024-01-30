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
    /// PublicGetUsersPlatformInfosV3
    ///
    /// Note:
    /// 1. the max count of user ids in the request is 100
    /// 2. if platform id is not empty, the result will only contain the corresponding platform infos
    /// 3. if platform id is empty, the result will contain all the supported platform infos
    /// 
    /// __Supported 3rd platforms:__
    /// 
    /// * __PSN(ps4web, ps4, ps5)__
    /// * display name
    /// * avatar
    /// * __Xbox(live, xblweb)__
    /// * display name
    /// * __Steam(steam, steamopenid)__
    /// * display name
    /// * avatar
    /// * __EpicGames(epicgames)__
    /// * display name
    /// </summary>
    public class PublicGetUsersPlatformInfosV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetUsersPlatformInfosV3Builder Builder { get => new PublicGetUsersPlatformInfosV3Builder(); }

        public class PublicGetUsersPlatformInfosV3Builder
            : OperationBuilder<PublicGetUsersPlatformInfosV3Builder>
        {





            internal PublicGetUsersPlatformInfosV3Builder() { }






            public PublicGetUsersPlatformInfosV3 Build(
                ModelUsersPlatformInfosRequestV3 body,
                string namespace_
            )
            {
                PublicGetUsersPlatformInfosV3 op = new PublicGetUsersPlatformInfosV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetUsersPlatformInfosV3(PublicGetUsersPlatformInfosV3Builder builder,
            ModelUsersPlatformInfosRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetUsersPlatformInfosV3(
            string namespace_,
            Model.ModelUsersPlatformInfosRequestV3 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/platforms";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUsersPlatformInfosResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelUsersPlatformInfosResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelUsersPlatformInfosResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUsersPlatformInfosResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}