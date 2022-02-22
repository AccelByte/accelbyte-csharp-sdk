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
    /// publicGetLanguages
    ///
    /// List languages.
    /// Other detail info:
    /// 
    ///   * Returns : language list
    /// </summary>
    public class PublicGetLanguages : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetLanguagesBuilder Builder = new PublicGetLanguagesBuilder();

        public class PublicGetLanguagesBuilder
        {
            
            internal PublicGetLanguagesBuilder() { }





            public PublicGetLanguages Build(
                string namespace_
            )
            {
                return new PublicGetLanguages(this,
                    namespace_                    
                );
            }
        }

        private PublicGetLanguages(PublicGetLanguagesBuilder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }
        #endregion

        public PublicGetLanguages(
            string namespace_            
        )
        {
            PathParams["namespace"] = namespace_;
            
            
            
            
            
        }

        public override string Path => "/basic/v1/public/namespaces/{namespace}/misc/languages";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Dictionary<string, object>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Dictionary<string, object>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}