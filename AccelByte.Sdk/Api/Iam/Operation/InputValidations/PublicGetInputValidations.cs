// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Iam.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Iam.Operation
{
    /// <summary>
    /// PublicGetInputValidations
    ///
    /// 
    /// 
    /// No role required
    /// 
    /// 
    /// 
    /// 
    /// This endpoint is to get list of input validation configuration.
    /// 
    /// 
    /// 
    /// 
    /// `regex` parameter will be returned if `isCustomRegex` is true. Otherwise, it will be empty.
    /// </summary>
    public class PublicGetInputValidations : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetInputValidationsBuilder Builder = new PublicGetInputValidationsBuilder();

        public class PublicGetInputValidationsBuilder
        {
            public bool? DefaultOnEmpty { get; set; }
            
            public string? LanguageCode { get; set; }
            
            internal PublicGetInputValidationsBuilder() { }


            public PublicGetInputValidationsBuilder SetDefaultOnEmpty(bool _defaultOnEmpty)
            {
                DefaultOnEmpty = _defaultOnEmpty;
                return this;
            }

            public PublicGetInputValidationsBuilder SetLanguageCode(string _languageCode)
            {
                LanguageCode = _languageCode;
                return this;
            }




            public PublicGetInputValidations Build(
            )
            {
                return new PublicGetInputValidations(this
                );
            }
        }

        private PublicGetInputValidations(PublicGetInputValidationsBuilder builder
        )
        {
            
            if (builder.DefaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(builder.DefaultOnEmpty)!;
            if (builder.LanguageCode != null) QueryParams["languageCode"] = builder.LanguageCode;
            
            
            
            
        }
        #endregion

        public PublicGetInputValidations(
            bool? defaultOnEmpty,            
            string? languageCode            
        )
        {
            
            if (defaultOnEmpty != null) QueryParams["defaultOnEmpty"] = Convert.ToString(defaultOnEmpty)!;
            if (languageCode != null) QueryParams["languageCode"] = languageCode;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/inputValidations";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelInputValidationsPublicResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsPublicResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelInputValidationsPublicResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}