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
    /// AdminListUsersV3
    ///
    /// This endpoint requires ADMIN:NAMESPACE:{namespace}:USER [READ] permission.
    /// 
    /// Returns list of users ID and namespace with their Justice platform account, under a namespace. If user
    /// doesn't have Justice platform account, the linkedPlatforms will be empty array.'
    /// </summary>
    public class AdminListUsersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminListUsersV3Builder Builder = new AdminListUsersV3Builder();

        public class AdminListUsersV3Builder
            : OperationBuilder<AdminListUsersV3Builder>
        {
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal AdminListUsersV3Builder() { }


            public AdminListUsersV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminListUsersV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public AdminListUsersV3 Build(
                string namespace_
            )
            {
                AdminListUsersV3 op = new AdminListUsersV3(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminListUsersV3(AdminListUsersV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminListUsersV3(
            string namespace_,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/users/platforms/justice";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.AccountcommonListUsersWithPlatformAccountsResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonListUsersWithPlatformAccountsResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.AccountcommonListUsersWithPlatformAccountsResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}