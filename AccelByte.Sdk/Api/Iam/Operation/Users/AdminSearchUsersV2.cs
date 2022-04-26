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
    /// AdminSearchUsersV2
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:USER [READ]'.
    /// </summary>
    public class AdminSearchUsersV2 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminSearchUsersV2Builder Builder = new AdminSearchUsersV2Builder();

        public class AdminSearchUsersV2Builder
            : OperationBuilder<AdminSearchUsersV2Builder>
        {
            
            public string? After { get; set; }
            
            public string? Before { get; set; }
            
            public string? DisplayName { get; set; }
            
            public long? Limit { get; set; }
            
            public string? LoginId { get; set; }
            
            public string? PlatformUserId { get; set; }
            
            public string? RoleId { get; set; }
            
            public string? UserId { get; set; }
            
            
            internal AdminSearchUsersV2Builder() { }


            public AdminSearchUsersV2Builder SetAfter(string _after)
            {
                After = _after;
                return this;
            }

            public AdminSearchUsersV2Builder SetBefore(string _before)
            {
                Before = _before;
                return this;
            }

            public AdminSearchUsersV2Builder SetDisplayName(string _displayName)
            {
                DisplayName = _displayName;
                return this;
            }

            public AdminSearchUsersV2Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminSearchUsersV2Builder SetLoginId(string _loginId)
            {
                LoginId = _loginId;
                return this;
            }

            public AdminSearchUsersV2Builder SetPlatformUserId(string _platformUserId)
            {
                PlatformUserId = _platformUserId;
                return this;
            }

            public AdminSearchUsersV2Builder SetRoleId(string _roleId)
            {
                RoleId = _roleId;
                return this;
            }

            public AdminSearchUsersV2Builder SetUserId(string _userId)
            {
                UserId = _userId;
                return this;
            }





            public AdminSearchUsersV2 Build(
                string namespace_,
                string platformId
            )
            {
                AdminSearchUsersV2 op = new AdminSearchUsersV2(this,
                    namespace_,                    
                    platformId                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminSearchUsersV2(AdminSearchUsersV2Builder builder,
            string namespace_,
            string platformId
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.After != null) QueryParams["after"] = builder.After;
            if (builder.Before != null) QueryParams["before"] = builder.Before;
            if (builder.DisplayName != null) QueryParams["displayName"] = builder.DisplayName;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.LoginId != null) QueryParams["loginId"] = builder.LoginId;
            if (builder.PlatformUserId != null) QueryParams["platformUserId"] = builder.PlatformUserId;
            if (builder.RoleId != null) QueryParams["roleId"] = builder.RoleId;
            if (builder.UserId != null) QueryParams["userId"] = builder.UserId;
            if (platformId != null) QueryParams["platformId"] = platformId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminSearchUsersV2(
            string namespace_,            
            string? after,            
            string? before,            
            string? displayName,            
            long? limit,            
            string? loginId,            
            string? platformUserId,            
            string? roleId,            
            string? userId,            
            string platformId            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (after != null) QueryParams["after"] = after;
            if (before != null) QueryParams["before"] = before;
            if (displayName != null) QueryParams["displayName"] = displayName;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (loginId != null) QueryParams["loginId"] = loginId;
            if (platformUserId != null) QueryParams["platformUserId"] = platformUserId;
            if (roleId != null) QueryParams["roleId"] = roleId;
            if (userId != null) QueryParams["userId"] = userId;
            if (platformId != null) QueryParams["platformId"] = platformId;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v2/admin/namespaces/{namespace}/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelSearchUsersByPlatformIDResponse? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersByPlatformIDResponse>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelSearchUsersByPlatformIDResponse>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}