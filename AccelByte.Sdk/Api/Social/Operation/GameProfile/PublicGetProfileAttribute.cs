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
    /// publicGetProfileAttribute
    ///
    /// Returns game profile attribute.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:GAMEPROFILE", action=2 (READ)
    ///         *  Returns : attribute info
    /// </summary>
    public class PublicGetProfileAttribute : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetProfileAttributeBuilder Builder { get => new PublicGetProfileAttributeBuilder(); }

        public class PublicGetProfileAttributeBuilder
            : OperationBuilder<PublicGetProfileAttributeBuilder>
        {





            internal PublicGetProfileAttributeBuilder() { }






            public PublicGetProfileAttribute Build(
                string attributeName,
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicGetProfileAttribute op = new PublicGetProfileAttribute(this,
                    attributeName,
                    namespace_,
                    profileId,
                    userId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;

                return op;
            }
        }

        private PublicGetProfileAttribute(PublicGetProfileAttributeBuilder builder,
            string attributeName,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PathParams["attributeName"] = attributeName;
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicGetProfileAttribute(
            string attributeName,
            string namespace_,
            string profileId,
            string userId
        )
        {
            PathParams["attributeName"] = attributeName;
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;







            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}/attributes/{attributeName}";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.Attribute? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.Attribute>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.Attribute>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.Attribute>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}