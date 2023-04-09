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
    /// publicGetCountries
    ///
    /// List countries.
    /// Other detail info:
    /// 
    ///   * Returns : country code list
    /// </summary>
    public class PublicGetCountries : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetCountriesBuilder Builder { get => new PublicGetCountriesBuilder(); }

        public class PublicGetCountriesBuilder
            : OperationBuilder<PublicGetCountriesBuilder>
        {

            public string? Lang { get; set; }





            internal PublicGetCountriesBuilder() { }


            public PublicGetCountriesBuilder SetLang(string _lang)
            {
                Lang = _lang;
                return this;
            }





            public PublicGetCountries Build(
                string namespace_
            )
            {
                PublicGetCountries op = new PublicGetCountries(this,
                    namespace_
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private PublicGetCountries(PublicGetCountriesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;

            if (builder.Lang is not null) QueryParams["lang"] = builder.Lang;






        }
        #endregion

        public PublicGetCountries(
            string namespace_,
            string? lang
        )
        {
            PathParams["namespace"] = namespace_;

            if (lang is not null) QueryParams["lang"] = lang;






        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/misc/countries";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("2022-04-19 - Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";

        public List<Model.CountryObject>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.CountryObject>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.CountryObject>>(payload);
            }

            var payloadString = Helper.ConvertInputStreamToString(payload);

            throw new HttpResponseException(code, payloadString);
        }
    }

}