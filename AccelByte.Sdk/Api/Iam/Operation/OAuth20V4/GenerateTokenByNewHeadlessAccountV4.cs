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
    /// GenerateTokenByNewHeadlessAccountV4
    ///
    /// This endpoint is being used to create headless account after 3rd platform authenticated, and response token .
    /// The 'linkingToken' in request body is received from "/platforms/{platformId}/token"
    /// when 3rd platform account is not linked to justice account yet.
    /// </summary>
    public class GenerateTokenByNewHeadlessAccountV4 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GenerateTokenByNewHeadlessAccountV4Builder Builder { get => new GenerateTokenByNewHeadlessAccountV4Builder(); }

        public class GenerateTokenByNewHeadlessAccountV4Builder
            : OperationBuilder<GenerateTokenByNewHeadlessAccountV4Builder>
        {



            public string? AdditionalData { get; set; }

            public bool? ExtendExp { get; set; }



            internal GenerateTokenByNewHeadlessAccountV4Builder() { }




            public GenerateTokenByNewHeadlessAccountV4Builder SetAdditionalData(string _additionalData)
            {
                AdditionalData = _additionalData;
                return this;
            }

            public GenerateTokenByNewHeadlessAccountV4Builder SetExtendExp(bool _extendExp)
            {
                ExtendExp = _extendExp;
                return this;
            }



            public GenerateTokenByNewHeadlessAccountV4 Build(
                string linkingToken
            )
            {
                GenerateTokenByNewHeadlessAccountV4 op = new GenerateTokenByNewHeadlessAccountV4(this,
                    linkingToken
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private GenerateTokenByNewHeadlessAccountV4(GenerateTokenByNewHeadlessAccountV4Builder builder,
            string linkingToken
        )
        {


            if (builder.AdditionalData is not null) FormParams["additionalData"] = builder.AdditionalData;
            if (builder.ExtendExp != null) FormParams["extend_exp"] = Convert.ToString(builder.ExtendExp)!;
            if (linkingToken is not null) FormParams["linkingToken"] = linkingToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GenerateTokenByNewHeadlessAccountV4(
            string? additionalData,
            bool? extendExp,
            string linkingToken
        )
        {


            if (additionalData is not null) FormParams["additionalData"] = additionalData;
            if (extendExp != null) FormParams["extend_exp"] = Convert.ToString(extendExp)!;
            if (linkingToken is not null) FormParams["linkingToken"] = linkingToken;





            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v4/oauth/headless/token";

        public override HttpMethod Method => HttpMethod.Post;

        public override string[] Consumes => new string[] { "application/x-www-form-urlencoded" };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.OauthmodelTokenResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelTokenResponseV3>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}