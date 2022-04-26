// Copyright (c) 2022 AccelByte Inc. All Rights Reserved.
// This is licensed software from AccelByte Inc, for limitations
// and restrictions contact your company contract manager.

using System.Net;
using System.IO;
using System.Text.Json;
using AccelByte.Sdk.Api.Leaderboard.Model;
using AccelByte.Sdk.Core;
using AccelByte.Sdk.Core.Util;

namespace AccelByte.Sdk.Api.Leaderboard.Operation
{
    /// <summary>
    /// getLeaderboardConfigurationsAdminV1
    ///
    /// Required permission 'ADMIN:NAMESPACE:{namespace}:LEADERBOARD [READ]'
    /// 
    /// 
    /// 
    /// 
    /// This endpoint return all leaderboard configurations
    /// </summary>
    public class GetLeaderboardConfigurationsAdminV1 : AccelByte.Sdk.Core.Operation
    {
        #region Builder Part
        public static GetLeaderboardConfigurationsAdminV1Builder Builder = new GetLeaderboardConfigurationsAdminV1Builder();

        public class GetLeaderboardConfigurationsAdminV1Builder
            : OperationBuilder<GetLeaderboardConfigurationsAdminV1Builder>
        {
            
            public bool? IsArchived { get; set; }
            
            public bool? IsDeleted { get; set; }
            
            public long? Limit { get; set; }
            
            public long? Offset { get; set; }
            
            internal GetLeaderboardConfigurationsAdminV1Builder() { }


            public GetLeaderboardConfigurationsAdminV1Builder SetIsArchived(bool _isArchived)
            {
                IsArchived = _isArchived;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetIsDeleted(bool _isDeleted)
            {
                IsDeleted = _isDeleted;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetLimit(long _limit)
            {
                Limit = _limit;
                return this;
            }

            public GetLeaderboardConfigurationsAdminV1Builder SetOffset(long _offset)
            {
                Offset = _offset;
                return this;
            }





            public GetLeaderboardConfigurationsAdminV1 Build(
                string namespace_
            )
            {
                GetLeaderboardConfigurationsAdminV1 op = new GetLeaderboardConfigurationsAdminV1(this,
                    namespace_                    
                );
                op.PreferredSecurityMethod = PreferredSecurityMethod;

                return op;
            }
        }

        private GetLeaderboardConfigurationsAdminV1(GetLeaderboardConfigurationsAdminV1Builder builder,
            string namespace_
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (builder.IsArchived != null) QueryParams["isArchived"] = Convert.ToString(builder.IsArchived)!;
            if (builder.IsDeleted != null) QueryParams["isDeleted"] = Convert.ToString(builder.IsDeleted)!;
            if (builder.Limit != null) QueryParams["limit"] = Convert.ToString(builder.Limit)!;
            if (builder.Offset != null) QueryParams["offset"] = Convert.ToString(builder.Offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }
        #endregion

        public GetLeaderboardConfigurationsAdminV1(
            string namespace_,            
            bool? isArchived,            
            bool? isDeleted,            
            long? limit,            
            long? offset            
        )
        {
            PathParams["namespace"] = namespace_;
            
            if (isArchived != null) QueryParams["isArchived"] = Convert.ToString(isArchived)!;
            if (isDeleted != null) QueryParams["isDeleted"] = Convert.ToString(isDeleted)!;
            if (limit != null) QueryParams["limit"] = Convert.ToString(limit)!;
            if (offset != null) QueryParams["offset"] = Convert.ToString(offset)!;
            

            
            
            

            Securities.Add(AccelByte.Sdk.Core.Operation.SECURITY_BEARER);
        }

        public override string Path => "/leaderboard/v1/admin/namespaces/{namespace}/leaderboards";

        public override HttpMethod Method => HttpMethod.Get;

        public override string[] Consumes => new string[] {  };

        public override string[] Produces => new string[] { "application/json" };

        [Obsolete("Use 'Securities' property instead.")]
        public override string? Security { get; set; } = "Bearer";
        
        public Model.ModelsGetAllLeaderboardConfigsResp? ParseResponse(HttpStatusCode code, string contentType, Stream payload)
        {            
            if (code == (HttpStatusCode)204)
            {
                return null;
            }
            else if (code == (HttpStatusCode)201)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsResp>(payload);
            }
            else if (code == (HttpStatusCode)200)
            {
                return JsonSerializer.Deserialize<Model.ModelsGetAllLeaderboardConfigsResp>(payload);
            }
            
            var payloadString = Helper.ConvertInputStreamToString(payload);
            
            throw new HttpResponseException(code, payloadString);
        }
    }
}