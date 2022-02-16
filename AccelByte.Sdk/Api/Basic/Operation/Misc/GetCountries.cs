// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Basic.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Basic.Operation
{
    /// <summary>
    /// getCountries
    ///
    /// List countries.
    /// Other detail info:
    /// 
    ///   * Required permission : login user
    ///   *  Action code : 11204
    ///   *  Returns : country code list
    /// </summary>
    public class GetCountries : AccelByte.Sdk.Core.Operation
    {
        public GetCountries(
            string namespace_,            
            string? lang            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (lang != null) QueryParams["lang"] = lang;
            
            
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countries";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
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