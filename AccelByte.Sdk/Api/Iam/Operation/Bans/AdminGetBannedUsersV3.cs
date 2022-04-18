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
    /// AdminGetBannedUsersV3
    ///
    /// Required permission 'ADMIN:BAN [READ]'
    /// Ban type is the code
    /// available for ban assignment. It is applicable globally for any namespace.
    /// action code : 10201
    /// </summary>
    public class AdminGetBannedUsersV3 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static AdminGetBannedUsersV3Builder Builder = new AdminGetBannedUsersV3Builder();

        public class AdminGetBannedUsersV3Builder
            : OperationBuilder<AdminGetBannedUsersV3Builder>
        {
            
            public bool? ActiveOnly { get; set; }
            
            public string? BanType { get; set; }
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal AdminGetBannedUsersV3Builder() { }


            public AdminGetBannedUsersV3Builder SetActiveOnly(bool _activeOnly)
            {
                ActiveOnly = _activeOnly;
                return this;
            }

            public AdminGetBannedUsersV3Builder SetBanType(string _banType)
            {
                BanType = _banType;
                return this;
            }

            public AdminGetBannedUsersV3Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public AdminGetBannedUsersV3Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }




            public AdminGetBannedUsersV3 Build(
                string namespace_
            )
            {
                AdminGetBannedUsersV3 op = new AdminGetBannedUsersV3(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private AdminGetBannedUsersV3(AdminGetBannedUsersV3Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.ActiveOnly != null) QueryParams["activeOnly"] = Convert.ToString(builder.ActiveOnly)!;
            if (builder.BanType != null) QueryParams["banType"] = builder.BanType;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public AdminGetBannedUsersV3(
            string namespace_,            
            bool? activeOnly,            
            string? banType,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (activeOnly != null) QueryParams["activeOnly"] = Convert.ToString(activeOnly)!;
            if (banType != null) QueryParams["banType"] = banType;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            
            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/iam/v3/admin/namespaces/{namespace}/bans/users";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelGetUserBanV3Response? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelGetUserBanV3Response>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}