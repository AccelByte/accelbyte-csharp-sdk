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
    /// publicUpdateAttribute
    ///
    /// Updates game profile attribute, returns updated profile.
    /// Other detail info:
    ///         *  Required permission : resource="NAMESPACE:{namespace}:USER:{userId}:GAMEPROFILE", action=4 (UPDATE)
    ///         *  Returns : updated attribute
    /// </summary>
    public class PublicUpdateAttribute : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicUpdateAttributeBuilder Builder { get => new PublicUpdateAttributeBuilder(); }

        public class PublicUpdateAttributeBuilder
            : OperationBuilder<PublicUpdateAttributeBuilder>
        {


            public Model.Attribute? Body { get; set; }




            internal PublicUpdateAttributeBuilder() { }



            public PublicUpdateAttributeBuilder SetBody(Model.Attribute _body)
            {
                Body = _body;
                return this;
            }




            public PublicUpdateAttribute Build(
                string attributeName,
                string namespace_,
                string profileId,
                string userId
            )
            {
                PublicUpdateAttribute op = new PublicUpdateAttribute(this,
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

        private PublicUpdateAttribute(PublicUpdateAttributeBuilder builder,
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





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicUpdateAttribute(
            string attributeName,
            string namespace_,
            string profileId,
            string userId,
            Model.Attribute body
        )
        {
            PathParams["attributeName"] = attributeName;
            PathParams["namespace"] = namespace_;
            PathParams["profileId"] = profileId;
            PathParams["userId"] = userId;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/social/public/namespaces/{namespace}/users/{userId}/profiles/{profileId}/attributes/{attributeName}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.GameProfileInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.GameProfileInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}