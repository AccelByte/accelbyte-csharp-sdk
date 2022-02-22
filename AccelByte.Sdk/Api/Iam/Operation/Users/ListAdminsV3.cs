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
    /// ListAdminsV3
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:USER [READ] permission.
    /// 
    /// List all users that has admin role (role that has admin_role attribute set to true).
    /// </summary>
    public class ListAdminsV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static ListAdminsV3Builder Builder = new ListAdminsV3Builder();

        public class ListAdminsV3Builder
        {
            
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public long? Limit { get; set; }
            
            internal ListAdminsV3Builder() { }


            public ListAdminsV3Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public ListAdminsV3Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public ListAdminsV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }




            public ListAdminsV3 Build(
                string namespace_
            )
            {
                return new ListAdminsV3(this,
                    namespace_                    
                );
            }
        }

        private ListAdminsV3(ListAdminsV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            
            
            
            
        }
        #endregion

        public ListAdminsV3(
            string namespace_,            
            string? after,            
            string? before,            
            long? limit            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            
            
            
            
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/admins";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        public override string? Security {get; set;} = "Bearer";
        
        public Model.ModelGetUsersResponseWithPaginationV3? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUsersResponseWithPaginationV3>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUsersResponseWithPaginationV3>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}