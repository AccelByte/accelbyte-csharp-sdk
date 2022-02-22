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
    /// GetCountryLocationV3
    ///
    /// 
    /// 
    /// This endpoint get country location based on the request.
    /// </summary>
    public class GetCountryLocationV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetCountryLocationV3Builder Builder = new GetCountryLocationV3Builder();

        public class GetCountryLocationV3Builder
        {
            internal GetCountryLocationV3Builder() { }





            public GetCountryLocationV3 Build(
            )
            {
                return new GetCountryLocationV3(this
                );
            }
        }

        private GetCountryLocationV3(GetCountryLocationV3Builder builder
        )
        {
            
            
            
            
            
        }
        #endregion

        public GetCountryLocationV3(
        )
        {
            
            
            
            
            
        }

        public override string Path => "/iam/v3/location/country";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.OauthmodelCountryLocationResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelCountryLocationResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.OauthmodelCountryLocationResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}