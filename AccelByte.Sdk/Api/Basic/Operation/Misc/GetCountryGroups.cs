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
    /// getCountryGroups
    ///
    /// List country groups. Will return all available country groups if the query param is not specified
    /// Other detail info:
    /// 
    ///   * Required permission : resource = "ADMIN:NAMESPACE:{namespace}:MISC" , action=2 (READ)
    ///   *  Action code : 11203
    ///   *  Returns : list of country groups
    /// </summary>
    public class GetCountryGroups : AccelByte.Sdk.Core.Operation
    {
        public GetCountryGroups(
            string namespace_,            
            string? groupCode            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (groupCode != null) QueryParams["groupCode"] = groupCode;
            
            
            
            
        }

        public override string Path => "/basic/v1/admin/namespaces/{namespace}/misc/countrygroups";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.RetrieveCountryGroupResponse>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveCountryGroupResponse>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.RetrieveCountryGroupResponse>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}