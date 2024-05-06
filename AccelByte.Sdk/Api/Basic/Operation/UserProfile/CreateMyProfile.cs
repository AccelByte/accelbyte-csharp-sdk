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
    /// createMyProfile
    ///
    /// Create my profile.
    ///  Client with user token can create user profile in target namespace
    /// Other detail info:
    /// 
    ///   * Action code : 11401
    ///   *  Returns : Created user profile
    ///   *  Path's namespace :
    ///     * can be filled with publisher namespace in order to create publisher user profile
    ///     * can be filled with game namespace in order to create game user profile
    ///   *  Language : allowed format: en, en-US
    ///   *  Country : ISO3166-1 alpha-2 two letter, e.g. US
    ///   * Timezone : IANA time zone, e.g. Asia/Shanghai
    /// </summary>
    public class CreateMyProfile : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static CreateMyProfileBuilder Builder { get => new CreateMyProfileBuilder(); }

        public class CreateMyProfileBuilder
            : OperationBuilder<CreateMyProfileBuilder>
        {


            public Model.UserProfilePrivateCreate? Body { get; set; }




            internal CreateMyProfileBuilder() { }



            public CreateMyProfileBuilder SetBody(Model.UserProfilePrivateCreate _body)
            {
                Body = _body;
                return this;
            }




            public CreateMyProfile Build(
                string namespace_
            )
            {
                CreateMyProfile op = new CreateMyProfile(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private CreateMyProfile(CreateMyProfileBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = builder.Body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public CreateMyProfile(
            string namespace_,
            Model.UserProfilePrivateCreate body
        )
        {
            PathParams["namespace"] = namespace_;





            BodyParams = body;


            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.UserProfilePrivateInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.UserProfilePrivateInfo<T1, T2>? ParseResponse<T1, T2>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo<T1, T2>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserProfilePrivateInfo<T1, T2>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}