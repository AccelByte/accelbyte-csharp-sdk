// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Social.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Social.Operation
{
    /// <summary>
    /// publicCreateUserStatItem
    ///
    /// Create user's statItem.
    /// Other detail info:
    ///             *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:STATITEM", action=1 (CREATE)
    ///             *  Returns : created user's statItem
    /// </summary>
    public class PublicCreateUserStatItem : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicCreateUserStatItemBuilder Builder { get => new PublicCreateUserStatItemBuilder(); }

        public class PublicCreateUserStatItemBuilder
            : OperationBuilder<PublicCreateUserStatItemBuilder>
        {





            internal PublicCreateUserStatItemBuilder() { }






            public PublicCreateUserStatItem Build(
                string namespace_,
                string statCode,
                string userId
            )
            {
                PublicCreateUserStatItem op = new PublicCreateUserStatItem(this,
                    namespace_,
                    statCode,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicCreateUserStatItem(PublicCreateUserStatItemBuilder builder,
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicCreateUserStatItem(
            string namespace_,
            string statCode,
            string userId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["statCode"] = statCode;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/v1/public/namespaces/{namespace}/users/{userId}/stats/{statCode}/statitems";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public void ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)201)
            {
                return;
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}