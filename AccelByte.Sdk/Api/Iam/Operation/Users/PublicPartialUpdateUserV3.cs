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
    /// PublicPartialUpdateUserV3
    ///
    /// Requires valid user access token
    /// 
    /// 
    /// 
    /// 
    /// 
    /// This Endpoint support update user based on given data. Single request can update single field or multi fields.
    /// 
    /// 
    /// 
    /// 
    /// Supported field {country, displayName, languageTag, dateOfBirth, avatarUrl}
    /// 
    /// 
    /// 
    /// 
    /// Country use ISO3166-1 alpha-2 two letter, e.g. US.
    /// 
    /// 
    /// 
    /// 
    /// Date of Birth format : YYYY-MM-DD, e.g. 2019-04-29.
    /// 
    /// 
    /// 
    ///  Several case of updating email address
    /// 
    /// 
    ///   * User want to update email address of which have been verified, newEmailAddress response field will be filled with new email address.
    /// 
    /// 
    ///   * User want to update email address of which have not been verified, { oldEmailAddress, emailAddress} response field will be filled with new email address.
    /// 
    /// 
    ///   * User want to update email address of which have been verified and updated before, { oldEmailAddress, emailAddress} response field will be filled with verified email before. newEmailAddress response field will be filled with newest email address.
    /// 
    /// 
    /// 
    /// action code : 10103
    /// </summary>
    public class PublicPartialUpdateUserV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicPartialUpdateUserV3Builder Builder { get => new PublicPartialUpdateUserV3Builder(); }

        public class PublicPartialUpdateUserV3Builder
            : OperationBuilder<PublicPartialUpdateUserV3Builder>
        {





            internal PublicPartialUpdateUserV3Builder() { }






            public PublicPartialUpdateUserV3 Build(
                ModelUserUpdateRequestV3 body,
                string namespace_
            )
            {
                PublicPartialUpdateUserV3 op = new PublicPartialUpdateUserV3(this,
                    body,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicPartialUpdateUserV3(PublicPartialUpdateUserV3Builder builder,
            ModelUserUpdateRequestV3 body,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicPartialUpdateUserV3(
            string namespace_,
            Model.ModelUserUpdateRequestV3 body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me";

        public override HttpMethod Method => HttpMethod.Patch;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelUserResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelUserResponseV3>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}