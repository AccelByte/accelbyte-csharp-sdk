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
    /// GetRoles
    ///
    /// Required permission 'ROLE [READ]'
    /// </summary>
    public class GetRoles : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetRolesBuilder Builder = new GetRolesBuilder();

        public class GetRolesBuilder
        {
            public string? IsWildcard { get; set; }
            
            internal GetRolesBuilder() { }


            public GetRolesBuilder SetIsWildcard(string _isWildcard)
            {
                IsWildcard = _isWildcard;
                return this;
            }




            public GetRoles Build(
            )
            {
                return new GetRoles(this
                );
            }
        }

        private GetRoles(GetRolesBuilder builder
        )
        {
            
            if (builder.IsWildcard != null) QueryParams["isWildcard"] = builder.IsWildcard;
            
            
            
            
        }
        #endregion

        public GetRoles(
            string? isWildcard            
        )
        {
            
            if (isWildcard != null) QueryParams["isWildcard"] = isWildcard;
            
            
            
            
        }

        public override string Path => "/iam/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public List<Model.ModelRoleResponseWithManagers>? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<List<Model.ModelRoleResponseWithManagers>>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<List<Model.ModelRoleResponseWithManagers>>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}