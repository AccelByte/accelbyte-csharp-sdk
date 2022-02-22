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
    /// PublicGetRolesV3
    ///
    /// 
    /// This endpoint is used to get all non-admin role.
    /// 
    /// 
    /// action code: 10418
    /// </summary>
    public class PublicGetRolesV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static PublicGetRolesV3Builder Builder = new PublicGetRolesV3Builder();

        public class PublicGetRolesV3Builder
        {
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public bool? IsWildcard { get; set; }
            
            public long? Limit { get; set; }
            
            internal PublicGetRolesV3Builder() { }


            public PublicGetRolesV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public PublicGetRolesV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public PublicGetRolesV3Builder SetIsWildcard(bool _isWildcard)
            {
                IsWildcard = _isWildcard;
                return this;
            }

            public PublicGetRolesV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }




            public PublicGetRolesV3 Build(
            )
            {
                return new PublicGetRolesV3(this
                );
            }
        }

        private PublicGetRolesV3(PublicGetRolesV3Builder builder
        )
        {
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.IsWildcard != null) QueryParams["isWildcard"] = Convert.ToString(builder.IsWildcard)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            
            
            
            
        }
        #endregion

        public PublicGetRolesV3(
            string? after,            
            string? before,            
            bool? isWildcard,            
            long? limit            
        )
        {
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (isWildcard != null) QueryParams["isWildcard"] = Convert.ToString(isWildcard)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/public/roles";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] { "application/json" };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelRoleNamesResponseV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleNamesResponseV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelRoleNamesResponseV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}