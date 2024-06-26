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
    /// PublicProcessWebLinkPlatformV3
    ///
    /// This endpoint is used to process third party account link, this endpoint will return the link status directly instead of redirecting to the original page.
    /// The param **state** comes from the response of `/users/me/platforms/{platformId}/web/link`
    /// Supported platforms:
    /// - ps4web
    /// - xblweb
    /// - steamopenid
    /// - epicgames
    /// - facebook
    /// - twitch
    /// - google
    /// - apple
    /// - snapchat
    /// - discord
    /// - amazon
    /// - oculusweb
    /// </summary>
    public class PublicProcessWebLinkPlatformV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicProcessWebLinkPlatformV3Builder Builder { get => new PublicProcessWebLinkPlatformV3Builder(); }

        public class PublicProcessWebLinkPlatformV3Builder
            : OperationBuilder<PublicProcessWebLinkPlatformV3Builder>
        {



            public string? Code { get; set; }



            internal PublicProcessWebLinkPlatformV3Builder() { }




            public PublicProcessWebLinkPlatformV3Builder SetCode(string _code)
            {
                Code = _code;
                return this;
            }



            public PublicProcessWebLinkPlatformV3 Build(
                string state,
                string namespace_,
                string platformId
            )
            {
                PublicProcessWebLinkPlatformV3 op = new PublicProcessWebLinkPlatformV3(this,
                    state,
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

        private PublicProcessWebLinkPlatformV3(PublicProcessWebLinkPlatformV3Builder builder,
            string state,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;


            if (builder.Code is not null) FormParams["code"] = builder.Code;
            if (state is not null) FormParams["state"] = state;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public PublicProcessWebLinkPlatformV3(
            string namespace_,
            string platformId,
            string? code,
            string state
        )
        {
            PathParams["namespace"] = namespace_;
            PathParams["platformId"] = platformId;


            if (code is not null) FormParams["code"] = code;
            if (state is not null) FormParams["state"] = state;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/public/namespaces/{namespace}/users/me/platforms/{platformId}/web/link/process";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.ModelLinkRequest? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.ModelLinkRequest>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.ModelLinkRequest>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }

        public Model.ModelLinkRequest<T1>? ParseResponse<T1>(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest<T1>>(payload, ResponseJsonOptions);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelLinkRequest<T1>>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);
            throw new HttpResponseException(code, payloadString);
        }
    }

}