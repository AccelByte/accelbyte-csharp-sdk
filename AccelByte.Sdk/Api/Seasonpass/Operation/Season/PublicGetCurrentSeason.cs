// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

// This code is generated by tool. DO NOT EDIT.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Seasonpass.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Seasonpass.Operation
{
    /// <summary>
    /// publicGetCurrentSeason
    ///
    /// This API is used to get current published season, season only located in non-publisher namespace.
    /// 
    /// Other detail info:
    /// 
    ///   * Returns : localized season data
    /// </summary>
    public class PublicGetCurrentSeason : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCurrentSeasonBuilder Builder { get => new PublicGetCurrentSeasonBuilder(); }

        public class PublicGetCurrentSeasonBuilder
            : OperationBuilder<PublicGetCurrentSeasonBuilder>
        {

            public string? Language { get; set; }





            internal PublicGetCurrentSeasonBuilder() { }


            public PublicGetCurrentSeasonBuilder SetLanguage(string _language)
            {
                Language = _language;
                return this;
            }





            public PublicGetCurrentSeason Build(
                string namespace_
            )
            {
                PublicGetCurrentSeason op = new PublicGetCurrentSeason(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;
                op.RequestJsonOptions = RequestJsonOptions;
                op.ResponseJsonOptions = ResponseJsonOptions;
                op.FlightId = FlightId;

                return op;
            }
        }

        private PublicGetCurrentSeason(PublicGetCurrentSeasonBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Language is not null) QueryParams["language"] = builder.Language;






        }
        #endregion

        public PublicGetCurrentSeason(
            string namespace_,
            string? language
        )
        {
            PathParams["namespace"] = namespace_;

            if (language is not null) QueryParams["language"] = language;






        }

        public override string Path => "/seasonpass/public/namespaces/{namespace}/seasons/current";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public Model.LocalizedSeasonInfo? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                if (ResponseJsonOptions != null)
                    return JsonSerializer.Deserialize<Model.LocalizedSeasonInfo>(payload, ResponseJsonOptions);
                else
                    return JsonSerializer.Deserialize<Model.LocalizedSeasonInfo>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.LocalizedSeasonInfo>(payload, ResponseJsonOptions);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}