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
    /// PublicPlatformUnlinkV3
    ///
    /// ## Supported platforms:
    /// - **steam**
    /// - **steamopenid**
    /// - **facebook**
    /// - **google**
    /// - **googleplaygames**
    /// - **oculus**
    /// - **twitch**
    /// - **android**
    /// - **ios**
    /// - **apple**
    /// - **device**
    /// - **discord**
    /// - **awscognito**
    /// - **epicgames**
    /// - **nintendo**
    /// 
    /// Unlink user's account from a specific platform. 'justice' platform might have multiple accounts from different namespaces linked.
    /// _platformNamespace_ need to be specified when the platform ID is 'justice'.
    /// Unlink user's account from justice platform will enable password token grant and password update.
    /// If you want to unlink user's account in a game namespace, you have to specify _platformNamespace_ to that game namespace.
    /// action code : 10121
    /// </summary>
    public class PublicPlatformUnlinkV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPlatformUnlinkV3Builder Builder { get => new PublicPlatformUnlinkV3Builder(); }

        public class PublicPlatformUnlinkV3Builder
            : OperationBuilder<PublicPlatformUnlinkV3Builder>
        {





            internal PublicPlatformUnlinkV3Builder() { }






            public PublicPlatformUnlinkV3 Build(
                ModelUnlinkUserPlatformRequest body,
                string namespace_,
                string platformId
            )
            {
                PublicPlatformUnlinkV3 op = new PublicPlatformUnlinkV3(this,
                    body,
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

        private PublicPlatformUnlinkV3(PublicPlatformUnlinkV3Builder builder,
            ModelUnlinkUserPlatformRequest body,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPlatformUnlinkV3(
            string namespace_,
            string platformId,
            Model.ModelUnlinkUserPlatformRequest body
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}";

        public override HttpMethod Method => HttpMethod.Delete;

        public override string[] Consumes => new string[] { "application/json" };

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

}