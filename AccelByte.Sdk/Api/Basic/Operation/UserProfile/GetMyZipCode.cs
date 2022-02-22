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
    /// getMyZipCode
    ///
    /// Get my zip code.
    /// Other detail info:
    /// 
    ///   * Required permission : resource= "NAMESPACE:{namespace}:PROFILE" , action=2 (READ)
    ///   *  Action code : 11407
    ///   *  Returns : user zip code
    /// </summary>
    public class GetMyZipCode : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetMyZipCodeBuilder Builder = new GetMyZipCodeBuilder();

        public class GetMyZipCodeBuilder
        {
            
            internal GetMyZipCodeBuilder() { }





            public GetMyZipCode Build(
                string namespace_
            )
            {
                return new GetMyZipCode(this,
                    namespace_                    
                );
            }
        }

        private GetMyZipCode(GetMyZipCodeBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public GetMyZipCode(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/users/me/profiles/zipCode";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.UserZipCode? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.UserZipCode>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.UserZipCode>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}