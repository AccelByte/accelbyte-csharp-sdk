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
    /// updateCountryGroup
    ///
    /// Update a country groups. The countryGroupCode must be exist beforehand.
    /// Valid update behaviour :
    /// - To update countryGroupName only, do not include countries key or just specify it with empty array.
    /// - To update countries only, do not include countryGroupName key or just specify it with blank value.
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:MISC" , action=4 (UPDATE)
    ///   *  Action code : 11202
    ///   *  Returns : updated country group
    /// </summary>
    public class UpdateCountryGroup : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static UpdateCountryGroupBuilder Builder = new UpdateCountryGroupBuilder();

        public class UpdateCountryGroupBuilder
        {
            
            
            public Model.UpdateCountryGroupRequest? Body { get; set; }
            
            internal UpdateCountryGroupBuilder() { }



            public UpdateCountryGroupBuilder SetBody(Model.UpdateCountryGroupRequest _body)
            {
                Body = _body;
                return this;
            }



            public UpdateCountryGroup Build(
                string countryGroupCode,
                string namespace_
            )
            {
                return new UpdateCountryGroup(this,
                    countryGroupCode,                    
                    namespace_                    
                );
            }
        }

        private UpdateCountryGroup(UpdateCountryGroupBuilder builder,
            string countryGroupCode,
            string namespace_
        )
        {
            PathParams["countryGroupCode"] = countryGroupCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = builder.Body;
            
        }
        #endregion

        public UpdateCountryGroup(
            string countryGroupCode,            
            string namespace_,            
            Model.UpdateCountryGroupRequest body            
        )
        {
            PathParams["countryGroupCode"] = countryGroupCode;
            PathParams["namespace"] = namespace_;
            
            
            
            
            BodyParams = body;
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countrygroups/{countryGroupCode}";

        public override HttpMethod Method => HttpMethod.Put;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.CountryGroupObject? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.CountryGroupObject>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.CountryGroupObject>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}