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
    /// RequestOneTimeLinkingCodeV3
    ///
    /// This endpoint is being used to request the one time code [8 length] for headless account to link or upgrade to a full account.
    /// Should specify the target platform id and current user should already linked to this platform.
    /// Current user should be a headless account.
    /// ## Supported platforms:
    /// - **steam**
    /// - **steamopenid**
    /// - **facebook**
    /// - **google**
    /// - **googleplaygames**
    /// - **oculus**
    /// - **twitch**
    /// - **discord**
    /// - **android**
    /// - **ios**
    /// - **apple**
    /// - **device**
    /// - **justice**
    /// - **epicgames**
    /// - **ps4**
    /// - **ps5**
    /// - **nintendo**
    /// - **awscognito**
    /// - **live**
    /// - **xblweb**
    /// - **netflix**
    /// - **snapchat**
    /// </summary>
    public class RequestOneTimeLinkingCodeV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static RequestOneTimeLinkingCodeV3Builder Builder { get => new RequestOneTimeLinkingCodeV3Builder(); }

        public class RequestOneTimeLinkingCodeV3Builder
            : OperationBuilder<RequestOneTimeLinkingCodeV3Builder>
        {



            public string? RedirectUri { get; set; }

            public string? State { get; set; }



            internal RequestOneTimeLinkingCodeV3Builder() { }




            public RequestOneTimeLinkingCodeV3Builder SetRedirectUri(string _redirectUri)
            {
                RedirectUri = _redirectUri;
                return this;
            }

            public RequestOneTimeLinkingCodeV3Builder SetState(string _state)
            {
                State = _state;
                return this;
            }



            public RequestOneTimeLinkingCodeV3 Build(
                string platformId
            )
            {
                RequestOneTimeLinkingCodeV3 op = new RequestOneTimeLinkingCodeV3(this,
                    platformId
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private RequestOneTimeLinkingCodeV3(RequestOneTimeLinkingCodeV3Builder builder,
            string platformId
        )
        {


            if (builder.RedirectUri is not null) FormParams["redirectUri"] = builder.RedirectUri;
            if (builder.State is not null) FormParams["state"] = builder.State;
            if (platformId is not null) FormParams["platformId"] = platformId;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public RequestOneTimeLinkingCodeV3(
            string? redirectUri,
            string? state,
            string platformId
        )
        {


            if (redirectUri is not null) FormParams["redirectUri"] = redirectUri;
            if (state is not null) FormParams["state"] = state;
            if (platformId is not null) FormParams["platformId"] = platformId;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/link/code/request";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.OauthmodelOneTimeLinkingCodeResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeResponse>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelOneTimeLinkingCodeResponse>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}